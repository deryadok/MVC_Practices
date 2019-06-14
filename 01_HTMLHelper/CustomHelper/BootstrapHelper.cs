using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_HTMLHelper.CustomHelper
{
    public static class BootstrapHelper
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string name, string text, ButtonType? type, string link, string @class)
        {
            TagBuilder button = new TagBuilder(name);

            if (link != null)
            {
                button.Attributes.Add("href", link);
                button.SetInnerText(text);
            }
            else
            {
                switch (type)
                {
                    case ButtonType.Button:
                        button.Attributes.Add("type", type.ToString());
                        break;
                    case ButtonType.Submit:
                        button.Attributes.Add("type", type.ToString());
                        break;
                    case ButtonType.Reset:
                        button.Attributes.Add("type", type.ToString());
                        break;
                }
                button.SetInnerText(text);
            }

            button.AddCssClass(@class);


            return MvcHtmlString.Create(button.ToString());
        }
    }

    public enum ButtonType
    {
        Button,
        Submit,
        Reset
    }
}