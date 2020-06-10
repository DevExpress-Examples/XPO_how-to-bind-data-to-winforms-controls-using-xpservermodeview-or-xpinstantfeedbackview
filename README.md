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
