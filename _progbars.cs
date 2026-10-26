


using static Ephemera.AudioLib.Globals;
namespace Ephemera.AudioLib
{
    public partial class ProgressBar : UserControl
    {
        Bitmap? _thumbnail = null;
        int _current = 0;
        int _lastXPos = 0;
        int _length = 0;
        int _selLength = 0;
        int _selStart = 0;

        public Bitmap? Thumbnail { get { return _thumbnail; } set { _thumbnail = value; Invalidate(); } }
        public Color MarkColor { set { _penMark.Color = value; Invalidate(); } }
        public Color ProgressColor { set { _penProgress.Color = value; Invalidate(); } }
        public Color TextColor { set { _textBrush.Color = value; Invalidate(); } }
        public Font FontLarge { get; set; } = new("Microsoft Sans Serif", 20, FontStyle.Regular, GraphicsUnit.Point, 0);
        public Font FontSmall { get; set; } = new("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point, 0);
        public int Current { get { return _current; } set { _current = value; Invalidate(); } } // Refresh
        public int Length { get { return _length; } set { _length = value; Invalidate(); } }
        public int SelLength { get { return _selLength; } set { _selLength = value; Invalidate(); } }
        public int SelStart { get { return _selStart; } set { _selStart = value; Invalidate(); } }

        readonly IContainer components;
        readonly Pen _penMark = new(Color.Red, 2);
        readonly Pen _penProgress = new(Color.LightGray, 2);
        readonly SnapType _snap = SnapType.Fine;
        readonly SolidBrush _textBrush = new(Color.Black);
        readonly StringFormat _format = new() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
        readonly ToolTip toolTip;

        public event EventHandler? CurrentChanged;

        int PixelToSample(int pixel)
        int SampleToPixel(int sample)

        protected override void Dispose(bool disposing)
        protected override void OnMouseDown(MouseEventArgs e)
        protected override void OnMouseMove(MouseEventArgs e)
        protected override void OnPaint(PaintEventArgs pe)

        public ProgressBar()
    }
}

namespace Midifrier
{
    public class ProgressBar : UserControl
    {
        int _lastXPos = 0;
        readonly Pen _penMarker = new(Color.Red, 1);
        readonly StringFormat _format = new();
        readonly ToolTip _toolTip = new();

        int GetClientFromTick(int tick)
        int GetTickFromClient(int x)

        protected override void Dispose(bool disposing)

        protected override void OnLoad(EventArgs e)
        protected override void OnMouseDown(MouseEventArgs e)
        protected override void OnMouseMove(MouseEventArgs e)
        protected override void OnPaint(PaintEventArgs pe)

        public bool DoLoop { get; set; } = false;
        public Color DrawColor { get; set; } = Color.Red;
        public Font FontLarge { get; set; } = new("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, 0);
        public Font FontSmall { get; set; } = new("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point, 0);
        public MusicTime Current { get; } = MusicTime.ZERO;
        public MusicTime Length { get; set; } = MusicTime.ZERO;

        public bool Increment()
        public class StateChangeEventArgs : EventArgs
        public event EventHandler<StateChangeEventArgs>? StateChange;
        public override string ToString()
        public ProgressBar()
        public void Rewind()

    }
}
