using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.TextFormatting;
using SharpEdit.VisualRendering;

namespace SharpEdit.CodeRendering
{
    public abstract class TextFormattingControl : Control
    {
        #region Constructors

        static TextFormattingControl()
        {
            AffectsRender<TextFormattingControl>(
                BackgroundProperty,
                ForegroundProperty,
                ParagraphPropertiesProperty);
        }

        #endregion

        #region Background

        public IBrush? Background
        {
            get => GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }

        public static readonly StyledProperty<IBrush?> BackgroundProperty
            = AvaloniaProperty.Register<NumberColumn, IBrush?>(nameof(Background));

        #endregion

        #region Foreground

        public IBrush? Foreground
        {
            get => GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }

        public static readonly DirectProperty<NumberColumn, IBrush?> ForegroundProperty
            = AvaloniaProperty.RegisterDirect<NumberColumn, IBrush?>(nameof(Foreground),
                getter: (owner) =>
                {
                    return owner.ParagraphProperties.DefaultTextRunProperties.ForegroundBrush;
                },
                setter: (owner, value) =>
                {
                    owner.ParagraphProperties.WithForeground(value);
                });

        #endregion

        #region ParagraphProperties

        public TextParagraphProperties ParagraphProperties
        {
            get => GetValue(ParagraphPropertiesProperty);
            set => SetValue(ParagraphPropertiesProperty, value);
        }

        public static readonly StyledProperty<TextParagraphProperties> ParagraphPropertiesProperty
            = AvaloniaProperty.Register<NumberColumn, TextParagraphProperties>(nameof(ParagraphProperties));

        #endregion

        #region Render

        public override void Render(DrawingContext context)
        {
            // Draw background
            context.DrawRectangle(Background, null, Bounds);
        }

        #endregion
    }
}
