
namespace iTin.Core
{
    using System.Xml;

    using Logging;

    /// <summary>
    /// Static class than contains extension methods for <see cref="T:System.Xml.XmlNode"/> objects.
    /// </summary> 
    public static class XmlNodeExtensions
    {
        /// <summary>
        /// Finds specified node in <paramref name="nodeName"/> into current node. If not found returns <b>null</b> (<b>Nothing</b> in Visual Basic).
        /// </summary>
        /// <param name="node">Root node.</param>
        /// <param name="nodeName">Target node.</param>
        /// <returns>
        /// A <see cref="T:System.Xml.XmlNode"/> founded.
        /// </returns>
        public static XmlNode FindNode(this XmlNode node, string nodeName)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StreamExtensions");
            Logger.Instance.Debug(" Finds specified node in NodeName into current node. If not found returns null (Nothing in Visual Basic).");
            Logger.Instance.Debug($" > Signature: ({typeof(XmlNode)}) FindNode(this {typeof(XmlNode)}, {typeof(string)})");
            Logger.Instance.Debug($"   > node: {node.Name}");
            Logger.Instance.Debug($"   > nodeName: {nodeName}");

            if (node.Name == nodeName)
            {
                Logger.Instance.Debug($" > Output: {node}");
                return node;
            }

            if (!node.HasChildNodes)
            {
                Logger.Instance.Debug(" > Output: null");
                return null;
            }

            node = node.FirstChild;
            while (node != null)
            {
                if (FindNode(node, nodeName) != null)
                {
                    return FindNode(node, nodeName);
                }

                node = node.NextSibling;
            }

            Logger.Instance.Debug(" > Output: null");
            return null;
        }
    }
}
