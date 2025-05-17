namespace Shoppist.Presentation.Shared.Core.Components;

public static class AppButtonExtensions
{
    public static string GetName(this AppButtonType type)
    {
        return type switch
        {
            AppButtonType.Button => "button",
            AppButtonType.Submit => "submit",
            AppButtonType.Reset => "reset",
            _ => "button"
        };
    }

    public static string GetCssClasses(this AppButtonStyleType style)
    {
        return style switch
        {
            AppButtonStyleType.Btn => "btn",
            AppButtonStyleType.BtnPrimary => "btn btn-primary",
            AppButtonStyleType.BtnSecondary => "btn btn-secondary",
            AppButtonStyleType.BtnSuccess => "btn btn-success",
            AppButtonStyleType.BtnDanger => "btn btn-danger",
            AppButtonStyleType.BtnWarning => "btn btn-warning",
            AppButtonStyleType.BtnInfo => "btn btn-info",
            AppButtonStyleType.BtnLight => "btn btn-light",
            AppButtonStyleType.BtnDark => "btn btn-dark",
            AppButtonStyleType.BtnLink => "btn btn-link",
            AppButtonStyleType.BtnOutlinePrimary => "btn btn-outline-primary",
            AppButtonStyleType.BtnOutlineSecondary => "btn btn-outline-secondary",
            AppButtonStyleType.BtnOutlineSuccess => "btn btn-outline-success",
            AppButtonStyleType.BtnOutlineDanger => "btn btn-outline-danger",
            AppButtonStyleType.BtnOutlineWarning => "btn btn-outline-warning",
            AppButtonStyleType.BtnOutlineInfo => "btn btn-outline-info",
            AppButtonStyleType.BtnOutlineLight => "btn btn-outline-light",
            AppButtonStyleType.BtnOutlineDark => "btn btn-outline-dark",
            _ => string.Empty
        };
    }

    public static string GetCssClasses(this AppButtonSize size)
    {
        return size switch
        {
            AppButtonSize.BtnLg => "btn-lg",
            AppButtonSize.BtnSm => "btn-sm",
            _ => string.Empty
        };
    }
}