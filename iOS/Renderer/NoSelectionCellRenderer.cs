using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using ListviewNoSelection.Controls;

[assembly: ExportRenderer(typeof(NoSelectionCell), typeof(ListviewNoSelection.iOS.Renderer.NoSelectionCellRenderer))]
namespace ListviewNoSelection.iOS.Renderer
{
    public class NoSelectionCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            UITableViewCell cell = base.GetCell(item, reusableCell, tv);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}