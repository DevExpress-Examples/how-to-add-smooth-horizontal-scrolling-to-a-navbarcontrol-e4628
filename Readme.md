# How to add smooth horizontal scrolling to a NavBarControl


<p>This example demonstrates how to add smooth horizontal scrolling to a NavBarControl.</p><p>To activate this functionality, add the "ScrollerResources.xaml" resource dictionary to the NavBarControl resources. For example:</p><p><br />


```xaml
    <dxn:NavBarControl>
        <dxn:NavBarControl.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary Source="ScrollerResources.xaml"/>
                </ResourceDictionary.MergedDictionaries>
            </ResourceDictionary>
        </dxn:NavBarControl.Resources>
    </dxn:NavBarControl>
```

</p><p>This solution doesn't work for ExplorerBarView.</p>

<br/>


