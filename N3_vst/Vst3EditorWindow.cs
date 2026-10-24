using NAudio.Vst3;
using System;

namespace N3_vst
{
    internal class Vst3EditorWindow
    {
        private string v;
        private Vst3PluginView view;

        public Vst3EditorWindow(string v, Vst3PluginView view)
        {
            this.v = v;
            this.view = view;
        }

        public Func<object, object, Vst3EditorWindow> ClosedByUser { get; internal set; }

        internal void Activate()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}