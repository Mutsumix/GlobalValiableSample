using Reactive.Bindings;
using System.ComponentModel;


namespace GlobalValiableSample
{
    internal class GlobalValiable
    {
        public static ReactiveProperty<string> Factory { get; } = new ReactiveProperty<string>();
        
    }
}
