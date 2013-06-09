using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	RadioButton[] radioButtons;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		radioButtons = new RadioButton[]{
			radiobuttonLvType60,
			radiobuttonLvType80,
			radiobuttonLvType100,
			radiobuttonLvType105,
			radiobuttonLvType125,
			radiobuttonLvType164
		};
		CalcExp ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnHscaleLvValueChanged (object sender, EventArgs e)
	{
		spinbuttonLv.Value = (double)(int)hscaleLv.Value;
		CalcExp ();
	}

	protected void OnSpinbuttonLvValueChanged (object sender, EventArgs e)
	{
		hscaleLv.Value = spinbuttonLv.Value;
		CalcExp ();
	}
	
	protected void OnRadiobuttonLvTypeChanged (object sender, EventArgs e)
	{
		CalcExp ();
	}

	protected void CalcExp ()
	{
		foreach(RadioButton i in radioButtons)
		{
			if (i.State == StateType.Active) {
				i.Click ();
			}
		}
	}

	protected void ShowExp (int exp)
	{
		labelExp.Text = string.Format ("{0:#,0}Exp", exp);
	}

	protected void ShowExp (double exp)
	{
		ShowExp((int)exp);
	}

	protected void Okasii ()
	{
		labelExp.Text = "ごめんなんか不具合出てる";
	}

	protected void OnRadiobuttonLvType60Clicked (object sender, EventArgs e)
	{
		int lv = (int)spinbuttonLv.Value;
		int lv3 = lv * lv * lv;

		if (lv <= 50) {
			ShowExp (lv3 * (100 - lv) * 0.02);
		} else if (lv <= 68) {
			ShowExp (lv3 * (150 - lv) * 0.01);
		} else if (lv <= 98) {
			ShowExp (lv3 * (int)(637 - (lv / 0.3)) * 0.002);
		} else if (lv <= 100) {
			ShowExp (lv3 * (160 - lv) * 0.01);
		}
	}

	protected void OnRadiobuttonLvType80Clicked (object sender, EventArgs e)
	{
		int lv = (int)spinbuttonLv.Value;
		ShowExp (0.8 * lv * lv * lv);
	}

	protected void OnRadiobuttonLvType100Clicked (object sender, EventArgs e)
	{
		int lv = (int)spinbuttonLv.Value;
		ShowExp (lv * lv * lv);
	}

	protected void OnRadiobuttonLvType105Clicked (object sender, EventArgs e)
	{
		int lv = (int)spinbuttonLv.Value;
		int lv2 = lv * lv;
		int lv3 = lv2 * lv;
		ShowExp ((1.2 * lv3) - (15 * lv2) + (100 * lv) - 140);
	}

	protected void OnRadiobuttonLvType125Clicked (object sender, EventArgs e)
	{
		int lv = (int)spinbuttonLv.Value;
		int lv3 = lv * lv * lv;
		ShowExp (1.25 * lv3);
	}

	protected void OnRadiobuttonLvType164Clicked (object sender, EventArgs e)
	{
		int lv = (int)spinbuttonLv.Value;
		int lv3 = lv * lv * lv;
		if (lv <= 15) {
			ShowExp (lv3 * (24 + (int)((lv + 1) / 3) * 0.02));
		} else if (lv <= 36) {
			ShowExp (lv3 * (14 + lv) * 0.02);
		} else if (lv <= 100) {
			ShowExp (lv3 * (32 + (int)(lv * 0.5)) * 0.02);
		}
	}

}
