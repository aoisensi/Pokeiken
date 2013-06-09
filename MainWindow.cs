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

	protected void OnRadiobuttonLvType164GroupChanged (object sender, EventArgs e)
	{
		CalcExp ();
	}

	protected void CalcExp ()
	{
		int lv = (int)spinbuttonLv.Value;

	}
}
