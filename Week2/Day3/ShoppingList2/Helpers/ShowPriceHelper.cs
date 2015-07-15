using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList2.Helpers
{
    public static class ShowPriceHelper
    {
        public static MvcHtmlString ShowPrice<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            // get view model property name
            string name = ExpressionHelper.GetExpressionText(expression);

            // get view model property meta data
            ModelMetadata metaData = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);

            // display price
            string text = string.Format("{0} is {1:c}", name, metaData.Model);
            return MvcHtmlString.Create(text);
        }
    }
}