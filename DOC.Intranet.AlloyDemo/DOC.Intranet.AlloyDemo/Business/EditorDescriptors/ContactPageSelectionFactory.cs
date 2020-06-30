using System.Collections.Generic;
using System.Linq;
using EPiServer.Shell.ObjectEditing;

namespace DOC.Intranet.Demo.Business.EditorDescriptors
{
    /// <summary>
    /// Provides a list of options corresponding to ContactPage pages on the site
    /// </summary>
    /// <seealso cref="ContactPageSelector"/>
    public class ContactPageSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var contactPages = SiteDataFactory.Instance.GetContactPages();

            return new List<SelectItem>(contactPages.Select(c => new SelectItem {Value = c.PageLink, Text = c.Name}));
        }
    }
}
