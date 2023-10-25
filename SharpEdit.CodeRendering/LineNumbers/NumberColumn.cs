using Avalonia;
using Avalonia.Media;
using Avalonia.Media.TextFormatting;
using SharpEdit.Utils;

namespace SharpEdit.CodeRendering
{
    public class NumberColumn : TextFormattingControl, IDisposable
    {
        #region Constructors

        static NumberColumn()
        {
            AffectsRender<NumberColumn>(NumbersProperty);
            AffectsMeasure<NumberColumn>(NumbersProperty);
        }

        #endregion

        #region Numbers

        public IntRange Numbers
        {
            get => GetValue(NumbersProperty);
            set => SetValue(NumbersProperty, value);
        }

        public static readonly StyledProperty<IntRange> NumbersProperty
            = AvaloniaProperty.Register<NumberColumn, IntRange>(nameof(Numbers));

        #endregion

        #region PropertiesChanged

        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            if(change.Property == ParagraphPropertiesProperty)
            {
                UpdateTextLayout();
            }

            base.OnPropertyChanged(change);
        }

        #endregion

        #region Render

        private TextLayout? textLayout;

        public override void Render(DrawingContext context)
        {
            base.Render(context);

            // Draw the text after base.Render() because it should not be overlapped
            textLayout?.Draw(context, default);
        }

        private void UpdateTextLayout()
        {
            textLayout = new TextLayout(new NumberTextSource(Numbers), ParagraphProperties);
        }

        private Size GetTextLayoutBounds()
        {
            if (textLayout is not null)
            {
                return new Size(textLayout.WidthIncludingTrailingWhitespace, textLayout.Height);
            }

            return new Size(0, 0);
        }

        #endregion

        #region Arrange && Measure

        protected override Size ArrangeOverride(Size finalSize)
        {
            textLayout = new TextLayout(
                textSource: new NumberTextSource(Numbers),
                paragraphProperties: ParagraphProperties, 
                maxWidth: finalSize.Width,
                maxHeight: finalSize.Height);

            return GetTextLayoutBounds();
        }

        protected override Size MeasureCore(Size availableSize)
        {
            Size desiredSize = GetTextLayoutBounds();

            return new Size(
                Math.Min(desiredSize.Width, availableSize.Width),
                Math.Min(desiredSize.Height, availableSize.Height));
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            textLayout?.Dispose();
        }

        #endregion
    }
}
