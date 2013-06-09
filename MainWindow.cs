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
		int lv3 = lv * lv * lv;
		if (radiobuttonLvType60.State == StateType.Active) {

			if (lv <= 50) {
				ShowExp (lv3 * (100 - lv) * 0.02);
			} else if (lv <= 68) {
				ShowExp (lv3 * (150 - lv) * 0.01);
			} else if (lv <= 98) {
				ShowExp (lv3 * (int)(637 - (lv / 0.3)) * 0.002);
			} else if (lv <= 100) {
				ShowExp (lv3 * (160 - lv) * 0.01);
			}

		} else if (radiobuttonLvType80.State == StateType.Active) {



		} else if (radiobuttonLvType100.State == StateType.Active) {

			ShowExp (lv3);

		} else if (radiobuttonLvType105.State == StateType.Active) {



		} else if (radiobuttonLvType125.State == StateType.Active) {



		} else if (radiobuttonLvType164.State == StateType.Active) {

		} else {
			Okasii ();
		}
	}

	protected void ShowExp (int exp)
	{
		labelExp.Text = string.Format ("{0:#,0}Exp", exp);
	}

	protected void ShowExp (double exp)
	{
		labelExp.Text = string.Format ("{0:#,0}Exp", (int)exp);
	}

	protected void Okasii ()
	{
		labelExp.Text = "ごめんなんか不具合出てる";
	}
}
