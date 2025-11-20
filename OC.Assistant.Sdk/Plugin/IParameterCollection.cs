using System.Xml.Linq;

namespace OC.Assistant.Sdk.Plugin;

/// <summary>
/// Represents the interface for a plugin parameter collection.
/// </summary>
public interface IParameterCollection
{
    /// <summary>
    /// Updates the parameter collection with the given XML element.
    /// </summary>
    /// <param name="xElement"></param>
    void Update(XContainer xElement);
    /// <summary>
    /// Updates the parameter collection with the given parameters.
    /// </summary>
    /// <param name="parameter"></param>
    void Update(IEnumerable<IParameter> parameter);
    /// <summary>
    /// Converts the parameter collection to a list.
    /// </summary>
    /// <returns></returns>
    List<IParameter> ToList();

    /// <summary>
    /// Converts the parameter collection to an XML element.
    /// </summary>
    XElement ToXElement();
}