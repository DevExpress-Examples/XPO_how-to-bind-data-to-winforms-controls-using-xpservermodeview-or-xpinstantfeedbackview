<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/186412357/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828757)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to Bind Data to WinForms Data Grid Using XPO and XPServerModeView or XPInstantFeedbackView


These new read-only server mode components are mixtures of [XPServerCollectionSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPServerCollectionSource)/[XPInstantFeedbackSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPInstantFeedbackSource) and [XPView](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPView) for use with DevExpress Grid controls. 

They offer the following:
* Ability to handle large data sources with lower memory usage (will not load entire persistent object instance).
* Ability to customize SELECT statements and exclude unused data columns.
* Ability to Include reference property data in the root query to avoid the 1+N problem.
* Ability to Include custom (virtual) properties calculated on the server side with [ServerViewProperty](https://docs.devexpress.com/XPO/DevExpress.Xpo.ServerViewProperty).

For more information, see [XPServerModeView](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPServerModeView) and [XPInstantFeedbackView](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPInstantFeedbackView).

## How it works
Before using these components as a grid's data source, configure them as follows:
1. Set `ObjectType` and `Properties` in code or in the component designer. `ServerViewProperty` supports [persistent or aliased properties](https://www.devexpress.com/Support/Center/Question/Details/Q352044/is-it-possible-to-avoid-the-cannot-query-a-data-store-using-criterion-error-and-be-able) in expressions.
```cs
xpServerModeView1.ObjectType = typeof(Order);
xpInstantFeedbackView1.ObjectType = typeof(Order);

var viewProperties = new ServerViewProperty[] {
    new ServerViewProperty("Oid", SortDirection.Ascending, "[Oid]"),
    new ServerViewProperty("OrderDate", SortDirection.None, "[OrderDate]"),
    new ServerViewProperty("Customer", SortDirection.None, "[Customer.ContactName]"),
    new ServerViewProperty("ProductName", SortDirection.None, "[ProductName]"),
    new ServerViewProperty("Price", SortDirection.None, "[Price]"),
    new ServerViewProperty("Quantity", SortDirection.None, "[Quantity]"),
    new ServerViewProperty("TotalPrice", SortDirection.None, "[Quantity] * [Price]"),
    new ServerViewProperty("Tax", SortDirection.None, "[Quantity] * [Price] * 0.13")
};
xpServerModeView1.Properties.AddRange(viewProperties);
xpInstantFeedbackView1.Properties.AddRange(viewProperties);
```
2. Handle the `ResolveSession` event to provide a [Session](https://docs.devexpress.com/XPO/2022/feature-center/connecting-to-a-data-store/session), to retrieve objects from the data store.

```cs
session = new Session(XpoDefault.DataLayer);

xpServerModeView1.ResolveSession += (s, e) => {
    e.Session = session;
};

xpInstantFeedbackView1.ResolveSession += (s, e) => {
    e.Session = session;
};
```
3. For `XPInstantFeedbackView`, optionally handle the `DismissSession` event to manually dispose of the Session created in the `ResolveSession` event handler.
```cs
xpInstantFeedbackView1.DismissSession += (s, e) => {
    IDisposable session = e.Session as IDisposable;
    if (session != null) {
        session.Dispose();
    }
};
```
## Your feedback matters!
Please let us know if you experience any issues, unsupported scenarios or just have usage questions.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XPO_how-to-bind-data-to-winforms-controls-using-xpservermodeview-or-xpinstantfeedbackview&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XPO_how-to-bind-data-to-winforms-controls-using-xpservermodeview-or-xpinstantfeedbackview&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
