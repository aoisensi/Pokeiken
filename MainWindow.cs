using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnHscrollbarLvValueChanged (object sender, EventArgs e)
	{
		spinbuttonLv.Value = hscrollbarLv.Value;
		CalcExp ();
	}

	protected void OnSpinbuttonLvValueChanged (object sender, EventArgs e)
	{
		hscrollbarLv.Value = spinbuttonLv.Value;
		CalcExp ();
	}
	
	protected void OnRadiobuttonLvType100GroupChanged (object sender, EventArgs e)
	{
		CalcExp ();
	}

	protected void CalcExp ()
	{
		int lv = (int)spinbuttonLv.Value;
		if (radiobuttonLvType60.State == StateType.Active) {

		} else if (radiobuttonLvType80.State == StateType.Active) {

		} else if (radiobuttonLvType100.State == StateType.Active) {
			ShowExp (lv * lv * lv);
		} else if (radiobuttonLvType105.State == StateType.Active) {

		} else if (radiobuttonLvType125.State == StateType.Active) {

		} else if (radiobuttonLvType164.State == StateType.Active) {

		} else {
			labelExp.Text = "ごめんなんか不具合出てる";
		}
	}

	protected void ShowExp (int exp)
	{
		labelExp.Text = string.Format ("{0:#,0}Exp", exp);
	}
}
