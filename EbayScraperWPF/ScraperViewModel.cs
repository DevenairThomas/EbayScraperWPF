using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EbayScraperWPF
{
    public class ScraperViewModel : DependencyObject
    {
        public string TemplateName
        {
            get { return (string)GetValue(TemplateNameProperty); }
            set { SetValue(TemplateNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TemplateName. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TemplateNameProperty =
        DependencyProperty.Register("TemplateName", typeof(string), typeof(ScraperViewModel), new UIPropertyMetadata("Template1"));
    }
}
