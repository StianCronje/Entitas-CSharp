//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public MultipleContextStandardEventComponent multipleContextStandardEvent { get { return (MultipleContextStandardEventComponent)GetComponent(Test2ComponentsLookup.MultipleContextStandardEvent); } }
    public bool hasMultipleContextStandardEvent { get { return HasComponent(Test2ComponentsLookup.MultipleContextStandardEvent); } }

    public void AddMultipleContextStandardEvent(string newValue) {
        var index = Test2ComponentsLookup.MultipleContextStandardEvent;
        var component = CreateComponent<MultipleContextStandardEventComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMultipleContextStandardEvent(string newValue) {
        var index = Test2ComponentsLookup.MultipleContextStandardEvent;
        var component = CreateComponent<MultipleContextStandardEventComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMultipleContextStandardEvent() {
        RemoveComponent(Test2ComponentsLookup.MultipleContextStandardEvent);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity : IMultipleContextStandardEventEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher {

    static Entitas.IMatcher<Test2Entity> _matcherMultipleContextStandardEvent;

    public static Entitas.IMatcher<Test2Entity> MultipleContextStandardEvent {
        get {
            if (_matcherMultipleContextStandardEvent == null) {
                var matcher = (Entitas.Matcher<Test2Entity>)Entitas.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.MultipleContextStandardEvent);
                matcher.componentNames = Test2ComponentsLookup.componentNames;
                _matcherMultipleContextStandardEvent = matcher;
            }

            return _matcherMultipleContextStandardEvent;
        }
    }
}
