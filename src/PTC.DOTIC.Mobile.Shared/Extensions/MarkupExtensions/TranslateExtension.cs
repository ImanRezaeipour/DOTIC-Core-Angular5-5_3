using System;
using PTC.DOTIC.Core;
using PTC.DOTIC.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTC.DOTIC.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return Text;
            }

            return L.Localize(Text);
        }
    }
}