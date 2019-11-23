#pragma warning disable 0414

namespace Gypo.Input
{
	using UnityEngine;

	public class Gamepad
	{
		public enum Axis
		{
			LeftStickX,
			LeftStickY,

			RightStickX,
			RightStickY,

			LT,
			RT,
			LTRT,

			DPadX,
			DPadY,
		}

		public enum Button
		{
			A,
			B,
			X,
			Y,

			LB,
			RB,
			LT,
			RT,

			LS,
			RS,

			Back,
			Start,

			DPadDown,
			DPadLeft,
			DPadRight,
			DPadUp,

			LeftStickDown,
			LeftStickLeft,
			LeftStickRight,
			LeftStickUp,

			RightStickDown,
			RightStickLeft,
			RightStickRight,
			RightStickUp,
		}

		private const string JOYSTICK_AXIS_0 = "joystick axis 0";
		private const string JOYSTICK_AXIS_1 = "joystick axis 1";
		private const string JOYSTICK_AXIS_2 = "joystick axis 2";
		private const string JOYSTICK_AXIS_3 = "joystick axis 3";
		private const string JOYSTICK_AXIS_4 = "joystick axis 4";
		private const string JOYSTICK_AXIS_5 = "joystick axis 5";
		private const string JOYSTICK_AXIS_6 = "joystick axis 6";
		private const string JOYSTICK_AXIS_7 = "joystick axis 7";
		private const string JOYSTICK_AXIS_8 = "joystick axis 8";
		private const string JOYSTICK_AXIS_9 = "joystick axis 9";

		private const string JOYSTICK_1_AXIS_0 = "joystick 1 axis 0";
		private const string JOYSTICK_1_AXIS_1 = "joystick 1 axis 1";
		private const string JOYSTICK_1_AXIS_2 = "joystick 1 axis 2";
		private const string JOYSTICK_1_AXIS_3 = "joystick 1 axis 3";
		private const string JOYSTICK_1_AXIS_4 = "joystick 1 axis 4";
		private const string JOYSTICK_1_AXIS_5 = "joystick 1 axis 5";
		private const string JOYSTICK_1_AXIS_6 = "joystick 1 axis 6";
		private const string JOYSTICK_1_AXIS_7 = "joystick 1 axis 7";
		private const string JOYSTICK_1_AXIS_8 = "joystick 1 axis 8";
		private const string JOYSTICK_1_AXIS_9 = "joystick 1 axis 9";

		private const string JOYSTICK_2_AXIS_0 = "joystick 2 axis 0";
		private const string JOYSTICK_2_AXIS_1 = "joystick 2 axis 1";
		private const string JOYSTICK_2_AXIS_2 = "joystick 2 axis 2";
		private const string JOYSTICK_2_AXIS_3 = "joystick 2 axis 3";
		private const string JOYSTICK_2_AXIS_4 = "joystick 2 axis 4";
		private const string JOYSTICK_2_AXIS_5 = "joystick 2 axis 5";
		private const string JOYSTICK_2_AXIS_6 = "joystick 2 axis 6";
		private const string JOYSTICK_2_AXIS_7 = "joystick 2 axis 7";
		private const string JOYSTICK_2_AXIS_8 = "joystick 2 axis 8";
		private const string JOYSTICK_2_AXIS_9 = "joystick 2 axis 9";

		private const string JOYSTICK_3_AXIS_0 = "joystick 3 axis 0";
		private const string JOYSTICK_3_AXIS_1 = "joystick 3 axis 1";
		private const string JOYSTICK_3_AXIS_2 = "joystick 3 axis 2";
		private const string JOYSTICK_3_AXIS_3 = "joystick 3 axis 3";
		private const string JOYSTICK_3_AXIS_4 = "joystick 3 axis 4";
		private const string JOYSTICK_3_AXIS_5 = "joystick 3 axis 5";
		private const string JOYSTICK_3_AXIS_6 = "joystick 3 axis 6";
		private const string JOYSTICK_3_AXIS_7 = "joystick 3 axis 7";
		private const string JOYSTICK_3_AXIS_8 = "joystick 3 axis 8";
		private const string JOYSTICK_3_AXIS_9 = "joystick 3 axis 9";

		private const string JOYSTICK_4_AXIS_0 = "joystick 4 axis 0";
		private const string JOYSTICK_4_AXIS_1 = "joystick 4 axis 1";
		private const string JOYSTICK_4_AXIS_2 = "joystick 4 axis 2";
		private const string JOYSTICK_4_AXIS_3 = "joystick 4 axis 3";
		private const string JOYSTICK_4_AXIS_4 = "joystick 4 axis 4";
		private const string JOYSTICK_4_AXIS_5 = "joystick 4 axis 5";
		private const string JOYSTICK_4_AXIS_6 = "joystick 4 axis 6";
		private const string JOYSTICK_4_AXIS_7 = "joystick 4 axis 7";
		private const string JOYSTICK_4_AXIS_8 = "joystick 4 axis 8";
		private const string JOYSTICK_4_AXIS_9 = "joystick 4 axis 9";

		private const string JOYSTICK_BUTTON_0 = "joystick button 0";
		private const string JOYSTICK_BUTTON_1 = "joystick button 1";
		private const string JOYSTICK_BUTTON_2 = "joystick button 2";
		private const string JOYSTICK_BUTTON_3 = "joystick button 3";
		private const string JOYSTICK_BUTTON_4 = "joystick button 4";
		private const string JOYSTICK_BUTTON_5 = "joystick button 5";
		private const string JOYSTICK_BUTTON_6 = "joystick button 6";
		private const string JOYSTICK_BUTTON_7 = "joystick button 7";
		private const string JOYSTICK_BUTTON_8 = "joystick button 8";
		private const string JOYSTICK_BUTTON_9 = "joystick button 9";
		private const string JOYSTICK_BUTTON_10 = "joystick button 10";
		private const string JOYSTICK_BUTTON_11 = "joystick button 11";
		private const string JOYSTICK_BUTTON_12 = "joystick button 12";
		private const string JOYSTICK_BUTTON_13 = "joystick button 13";
		private const string JOYSTICK_BUTTON_14 = "joystick button 14";
		private const string JOYSTICK_BUTTON_15 = "joystick button 15";
		private const string JOYSTICK_BUTTON_16 = "joystick button 16";
		private const string JOYSTICK_BUTTON_17 = "joystick button 17";
		private const string JOYSTICK_BUTTON_18 = "joystick button 18";
		private const string JOYSTICK_BUTTON_19 = "joystick button 19";

		private const string JOYSTICK_1_BUTTON_0 = "joystick 1 button 0";
		private const string JOYSTICK_1_BUTTON_1 = "joystick 1 button 1";
		private const string JOYSTICK_1_BUTTON_2 = "joystick 1 button 2";
		private const string JOYSTICK_1_BUTTON_3 = "joystick 1 button 3";
		private const string JOYSTICK_1_BUTTON_4 = "joystick 1 button 4";
		private const string JOYSTICK_1_BUTTON_5 = "joystick 1 button 5";
		private const string JOYSTICK_1_BUTTON_6 = "joystick 1 button 6";
		private const string JOYSTICK_1_BUTTON_7 = "joystick 1 button 7";
		private const string JOYSTICK_1_BUTTON_8 = "joystick 1 button 8";
		private const string JOYSTICK_1_BUTTON_9 = "joystick 1 button 9";
		private const string JOYSTICK_1_BUTTON_10 = "joystick 1 button 10";
		private const string JOYSTICK_1_BUTTON_11 = "joystick 1 button 11";
		private const string JOYSTICK_1_BUTTON_12 = "joystick 1 button 12";
		private const string JOYSTICK_1_BUTTON_13 = "joystick 1 button 13";
		private const string JOYSTICK_1_BUTTON_14 = "joystick 1 button 14";
		private const string JOYSTICK_1_BUTTON_15 = "joystick 1 button 15";
		private const string JOYSTICK_1_BUTTON_16 = "joystick 1 button 16";
		private const string JOYSTICK_1_BUTTON_17 = "joystick 1 button 17";
		private const string JOYSTICK_1_BUTTON_18 = "joystick 1 button 18";
		private const string JOYSTICK_1_BUTTON_19 = "joystick 1 button 19";

		private const string JOYSTICK_2_BUTTON_0 = "joystick 2 button 0";
		private const string JOYSTICK_2_BUTTON_1 = "joystick 2 button 1";
		private const string JOYSTICK_2_BUTTON_2 = "joystick 2 button 2";
		private const string JOYSTICK_2_BUTTON_3 = "joystick 2 button 3";
		private const string JOYSTICK_2_BUTTON_4 = "joystick 2 button 4";
		private const string JOYSTICK_2_BUTTON_5 = "joystick 2 button 5";
		private const string JOYSTICK_2_BUTTON_6 = "joystick 2 button 6";
		private const string JOYSTICK_2_BUTTON_7 = "joystick 2 button 7";
		private const string JOYSTICK_2_BUTTON_8 = "joystick 2 button 8";
		private const string JOYSTICK_2_BUTTON_9 = "joystick 2 button 9";
		private const string JOYSTICK_2_BUTTON_10 = "joystick 2 button 10";
		private const string JOYSTICK_2_BUTTON_11 = "joystick 2 button 11";
		private const string JOYSTICK_2_BUTTON_12 = "joystick 2 button 12";
		private const string JOYSTICK_2_BUTTON_13 = "joystick 2 button 13";
		private const string JOYSTICK_2_BUTTON_14 = "joystick 2 button 14";
		private const string JOYSTICK_2_BUTTON_15 = "joystick 2 button 15";
		private const string JOYSTICK_2_BUTTON_16 = "joystick 2 button 16";
		private const string JOYSTICK_2_BUTTON_17 = "joystick 2 button 17";
		private const string JOYSTICK_2_BUTTON_18 = "joystick 2 button 18";
		private const string JOYSTICK_2_BUTTON_19 = "joystick 2 button 19";

		private const string JOYSTICK_3_BUTTON_0 = "joystick 3 button 0";
		private const string JOYSTICK_3_BUTTON_1 = "joystick 3 button 1";
		private const string JOYSTICK_3_BUTTON_2 = "joystick 3 button 2";
		private const string JOYSTICK_3_BUTTON_3 = "joystick 3 button 3";
		private const string JOYSTICK_3_BUTTON_4 = "joystick 3 button 4";
		private const string JOYSTICK_3_BUTTON_5 = "joystick 3 button 5";
		private const string JOYSTICK_3_BUTTON_6 = "joystick 3 button 6";
		private const string JOYSTICK_3_BUTTON_7 = "joystick 3 button 7";
		private const string JOYSTICK_3_BUTTON_8 = "joystick 3 button 8";
		private const string JOYSTICK_3_BUTTON_9 = "joystick 3 button 9";
		private const string JOYSTICK_3_BUTTON_10 = "joystick 3 button 10";
		private const string JOYSTICK_3_BUTTON_11 = "joystick 3 button 11";
		private const string JOYSTICK_3_BUTTON_12 = "joystick 3 button 12";
		private const string JOYSTICK_3_BUTTON_13 = "joystick 3 button 13";
		private const string JOYSTICK_3_BUTTON_14 = "joystick 3 button 14";
		private const string JOYSTICK_3_BUTTON_15 = "joystick 3 button 15";
		private const string JOYSTICK_3_BUTTON_16 = "joystick 3 button 16";
		private const string JOYSTICK_3_BUTTON_17 = "joystick 3 button 17";
		private const string JOYSTICK_3_BUTTON_18 = "joystick 3 button 18";
		private const string JOYSTICK_3_BUTTON_19 = "joystick 3 button 19";

		private const string JOYSTICK_4_BUTTON_0 = "joystick 4 button 0";
		private const string JOYSTICK_4_BUTTON_1 = "joystick 4 button 1";
		private const string JOYSTICK_4_BUTTON_2 = "joystick 4 button 2";
		private const string JOYSTICK_4_BUTTON_3 = "joystick 4 button 3";
		private const string JOYSTICK_4_BUTTON_4 = "joystick 4 button 4";
		private const string JOYSTICK_4_BUTTON_5 = "joystick 4 button 5";
		private const string JOYSTICK_4_BUTTON_6 = "joystick 4 button 6";
		private const string JOYSTICK_4_BUTTON_7 = "joystick 4 button 7";
		private const string JOYSTICK_4_BUTTON_8 = "joystick 4 button 8";
		private const string JOYSTICK_4_BUTTON_9 = "joystick 4 button 9";
		private const string JOYSTICK_4_BUTTON_10 = "joystick 4 button 10";
		private const string JOYSTICK_4_BUTTON_11 = "joystick 4 button 11";
		private const string JOYSTICK_4_BUTTON_12 = "joystick 4 button 12";
		private const string JOYSTICK_4_BUTTON_13 = "joystick 4 button 13";
		private const string JOYSTICK_4_BUTTON_14 = "joystick 4 button 14";
		private const string JOYSTICK_4_BUTTON_15 = "joystick 4 button 15";
		private const string JOYSTICK_4_BUTTON_16 = "joystick 4 button 16";
		private const string JOYSTICK_4_BUTTON_17 = "joystick 4 button 17";
		private const string JOYSTICK_4_BUTTON_18 = "joystick 4 button 18";
		private const string JOYSTICK_4_BUTTON_19 = "joystick 4 button 19";

		private static readonly string[] axis0 = new string[]
		{
			JOYSTICK_AXIS_0,
			JOYSTICK_1_AXIS_0,
			JOYSTICK_2_AXIS_0,
			JOYSTICK_3_AXIS_0,
			JOYSTICK_4_AXIS_0,
		};

		private static readonly string[] axis1 = new string[]
		{
			JOYSTICK_AXIS_1,
			JOYSTICK_1_AXIS_1,
			JOYSTICK_2_AXIS_1,
			JOYSTICK_3_AXIS_1,
			JOYSTICK_4_AXIS_1,
		};

		private static readonly string[] axis2 = new string[]
		{
			JOYSTICK_AXIS_2,
			JOYSTICK_1_AXIS_2,
			JOYSTICK_2_AXIS_2,
			JOYSTICK_3_AXIS_2,
			JOYSTICK_4_AXIS_2,
		};

		private static readonly string[] axis3 = new string[]
		{
			JOYSTICK_AXIS_3,
			JOYSTICK_1_AXIS_3,
			JOYSTICK_2_AXIS_3,
			JOYSTICK_3_AXIS_3,
			JOYSTICK_4_AXIS_3,
		};

		private static readonly string[] axis4 = new string[]
		{
			JOYSTICK_AXIS_4,
			JOYSTICK_1_AXIS_4,
			JOYSTICK_2_AXIS_4,
			JOYSTICK_3_AXIS_4,
			JOYSTICK_4_AXIS_4,
		};

		private static readonly string[] axis5 = new string[]
		{
			JOYSTICK_AXIS_5,
			JOYSTICK_1_AXIS_5,
			JOYSTICK_2_AXIS_5,
			JOYSTICK_3_AXIS_5,
			JOYSTICK_4_AXIS_5,
		};

		private static readonly string[] axis6 = new string[]
		{
			JOYSTICK_AXIS_6,
			JOYSTICK_1_AXIS_6,
			JOYSTICK_2_AXIS_6,
			JOYSTICK_3_AXIS_6,
			JOYSTICK_4_AXIS_6,
		};

		private static readonly string[] axis7 = new string[]
		{
			JOYSTICK_AXIS_7,
			JOYSTICK_1_AXIS_7,
			JOYSTICK_2_AXIS_7,
			JOYSTICK_3_AXIS_7,
			JOYSTICK_4_AXIS_7,
		};

		private static readonly string[] axis8 = new string[]
		{
			JOYSTICK_AXIS_8,
			JOYSTICK_1_AXIS_8,
			JOYSTICK_2_AXIS_8,
			JOYSTICK_3_AXIS_8,
			JOYSTICK_4_AXIS_8,
		};

		private static readonly string[] axis9 = new string[]
		{
			JOYSTICK_AXIS_9,
			JOYSTICK_1_AXIS_9,
			JOYSTICK_2_AXIS_9,
			JOYSTICK_3_AXIS_9,
			JOYSTICK_4_AXIS_9,
		};

		private static readonly string[] button0 = new string[]
		{
			JOYSTICK_BUTTON_0,
			JOYSTICK_1_BUTTON_0,
			JOYSTICK_2_BUTTON_0,
			JOYSTICK_3_BUTTON_0,
			JOYSTICK_4_BUTTON_0,
		};

		private static readonly string[] button1 = new string[]
		{
			JOYSTICK_BUTTON_1,
			JOYSTICK_1_BUTTON_1,
			JOYSTICK_2_BUTTON_1,
			JOYSTICK_3_BUTTON_1,
			JOYSTICK_4_BUTTON_1,
		};

		private static readonly string[] button2 = new string[]
		{
			JOYSTICK_BUTTON_2,
			JOYSTICK_1_BUTTON_2,
			JOYSTICK_2_BUTTON_2,
			JOYSTICK_3_BUTTON_2,
			JOYSTICK_4_BUTTON_2,
		};

		private static readonly string[] button3 = new string[]
		{
			JOYSTICK_BUTTON_3,
			JOYSTICK_1_BUTTON_3,
			JOYSTICK_2_BUTTON_3,
			JOYSTICK_3_BUTTON_3,
			JOYSTICK_4_BUTTON_3,
		};

		private static readonly string[] button4 = new string[]
		{
			JOYSTICK_BUTTON_4,
			JOYSTICK_1_BUTTON_4,
			JOYSTICK_2_BUTTON_4,
			JOYSTICK_3_BUTTON_4,
			JOYSTICK_4_BUTTON_4,
		};

		private static readonly string[] button5 = new string[]
		{
			JOYSTICK_BUTTON_5,
			JOYSTICK_1_BUTTON_5,
			JOYSTICK_2_BUTTON_5,
			JOYSTICK_3_BUTTON_5,
			JOYSTICK_4_BUTTON_5,
		};

		private static readonly string[] button6 = new string[]
		{
			JOYSTICK_BUTTON_6,
			JOYSTICK_1_BUTTON_6,
			JOYSTICK_2_BUTTON_6,
			JOYSTICK_3_BUTTON_6,
			JOYSTICK_4_BUTTON_6,
		};

		private static readonly string[] button7 = new string[]
		{
			JOYSTICK_BUTTON_7,
			JOYSTICK_1_BUTTON_7,
			JOYSTICK_2_BUTTON_7,
			JOYSTICK_3_BUTTON_7,
			JOYSTICK_4_BUTTON_7,
		};

		private static readonly string[] button8 = new string[]
		{
			JOYSTICK_BUTTON_8,
			JOYSTICK_1_BUTTON_8,
			JOYSTICK_2_BUTTON_8,
			JOYSTICK_3_BUTTON_8,
			JOYSTICK_4_BUTTON_8,
		};

		private static readonly string[] button9 = new string[]
		{
			JOYSTICK_BUTTON_9,
			JOYSTICK_1_BUTTON_9,
			JOYSTICK_2_BUTTON_9,
			JOYSTICK_3_BUTTON_9,
			JOYSTICK_4_BUTTON_9,
		};

		private static readonly string[] button10 = new string[]
		{
			JOYSTICK_BUTTON_10,
			JOYSTICK_1_BUTTON_10,
			JOYSTICK_2_BUTTON_10,
			JOYSTICK_3_BUTTON_10,
			JOYSTICK_4_BUTTON_10,
		};

		private static readonly string[] button11 = new string[]
		{
			JOYSTICK_BUTTON_11,
			JOYSTICK_1_BUTTON_11,
			JOYSTICK_2_BUTTON_11,
			JOYSTICK_3_BUTTON_11,
			JOYSTICK_4_BUTTON_11,
		};

		private static readonly string[] button12 = new string[]
		{
			JOYSTICK_BUTTON_12,
			JOYSTICK_1_BUTTON_12,
			JOYSTICK_2_BUTTON_12,
			JOYSTICK_3_BUTTON_12,
			JOYSTICK_4_BUTTON_12,
		};

		private static readonly string[] button13 = new string[]
		{
			JOYSTICK_BUTTON_13,
			JOYSTICK_1_BUTTON_13,
			JOYSTICK_2_BUTTON_13,
			JOYSTICK_3_BUTTON_13,
			JOYSTICK_4_BUTTON_13,
		};

		private static readonly string[] button14 = new string[]
		{
			JOYSTICK_BUTTON_14,
			JOYSTICK_1_BUTTON_14,
			JOYSTICK_2_BUTTON_14,
			JOYSTICK_3_BUTTON_14,
			JOYSTICK_4_BUTTON_14,
		};

		private static readonly string[] button15 = new string[]
		{
			JOYSTICK_BUTTON_15,
			JOYSTICK_1_BUTTON_15,
			JOYSTICK_2_BUTTON_15,
			JOYSTICK_3_BUTTON_15,
			JOYSTICK_4_BUTTON_15,
		};

		private static readonly string[] button16 = new string[]
		{
			JOYSTICK_BUTTON_16,
			JOYSTICK_1_BUTTON_16,
			JOYSTICK_2_BUTTON_16,
			JOYSTICK_3_BUTTON_16,
			JOYSTICK_4_BUTTON_16,
		};

		private static readonly string[] button17 = new string[]
		{
			JOYSTICK_BUTTON_17,
			JOYSTICK_1_BUTTON_17,
			JOYSTICK_2_BUTTON_17,
			JOYSTICK_3_BUTTON_17,
			JOYSTICK_4_BUTTON_17,
		};

		private static readonly string[] button18 = new string[]
		{
			JOYSTICK_BUTTON_18,
			JOYSTICK_1_BUTTON_18,
			JOYSTICK_2_BUTTON_18,
			JOYSTICK_3_BUTTON_18,
			JOYSTICK_4_BUTTON_18,
		};

		private static readonly string[] button19 = new string[]
		{
			JOYSTICK_BUTTON_19,
			JOYSTICK_1_BUTTON_19,
			JOYSTICK_2_BUTTON_19,
			JOYSTICK_3_BUTTON_19,
			JOYSTICK_4_BUTTON_19,
		};

		public static float GetAxis(Axis axis)
		{
			return GetAxis(axis, 0);
		}

		public static bool GetButton(Button button)
		{
			return GetButton(button, 0);
		}

#if !(UNITY_STANDALONE_OSX || UNITY_EDITOR_OSX)

		public static float GetAxis(Axis axis, int controllerIndex)
		{
			switch (axis)
			{
				case Axis.LeftStickX:
					return Input.GetAxisRaw(axis0[controllerIndex]);

				case Axis.LeftStickY:
					return Input.GetAxisRaw(axis1[controllerIndex]);

				case Axis.RightStickX:
					return Input.GetAxisRaw(axis3[controllerIndex]);

				case Axis.RightStickY:
					return Input.GetAxisRaw(axis4[controllerIndex]);

				case Axis.LT:
					return Input.GetAxisRaw(axis8[controllerIndex]);

				case Axis.RT:
					return Input.GetAxisRaw(axis9[controllerIndex]);

				case Axis.LTRT:
					return -Input.GetAxisRaw(axis8[controllerIndex]) + Input.GetAxisRaw(axis9[controllerIndex]);

				case Axis.DPadX:
					return Input.GetAxisRaw(axis5[controllerIndex]);

				case Axis.DPadY:
					return Input.GetAxisRaw(axis6[controllerIndex]);
			}

			return 0;
		}

		public static bool GetButton(Button button, int controllerIndex)
		{
			switch (button)
			{
				case Button.A:
					return Input.GetKey(button0[controllerIndex]);

				case Button.B:
					return Input.GetKey(button1[controllerIndex]);

				case Button.X:
					return Input.GetKey(button2[controllerIndex]);

				case Button.Y:
					return Input.GetKey(button3[controllerIndex]);

				case Button.LB:
					return Input.GetKey(button4[controllerIndex]);

				case Button.RB:
					return Input.GetKey(button5[controllerIndex]);

				case Button.LT:
					return GetAxis(Axis.LT, controllerIndex) > 0.5f;

				case Button.RT:
					return GetAxis(Axis.RT, controllerIndex) > 0.5f;

				case Button.Back:
					return Input.GetKey(button6[controllerIndex]);

				case Button.Start:
					return Input.GetKey(button7[controllerIndex]);

				case Button.LS:
					return Input.GetKey(button8[controllerIndex]);

				case Button.RS:
					return Input.GetKey(button9[controllerIndex]);

				case Button.DPadDown:
					return GetAxis(Axis.DPadY, controllerIndex) < -0.5f;

				case Button.DPadUp:
					return GetAxis(Axis.DPadY, controllerIndex) > 0.5f;

				case Button.DPadLeft:
					return GetAxis(Axis.DPadX, controllerIndex) < -0.5f;

				case Button.DPadRight:
					return GetAxis(Axis.DPadX, controllerIndex) > 0.5f;

				case Button.LeftStickDown:
					return GetAxis(Axis.LeftStickY, controllerIndex) > 0.5f;

				case Button.LeftStickLeft:
					return GetAxis(Axis.LeftStickX, controllerIndex) < -0.5f;

				case Button.LeftStickRight:
					return GetAxis(Axis.LeftStickX, controllerIndex) > 0.5f;

				case Button.LeftStickUp:
					return GetAxis(Axis.LeftStickY, controllerIndex) < -0.5f;

				case Button.RightStickDown:
					return GetAxis(Axis.RightStickY, controllerIndex) < -0.5f;

				case Button.RightStickLeft:
					return GetAxis(Axis.RightStickX, controllerIndex) < -0.5f;

				case Button.RightStickRight:
					return GetAxis(Axis.RightStickX, controllerIndex) > 0.5f;

				case Button.RightStickUp:
					return GetAxis(Axis.RightStickY, controllerIndex) > 0.5f;
			}

			return false;
		}

#else

		public static float GetAxis(Axis axis, int controllerIndex)
		{
			switch (axis)
			{
				case Axis.LeftStickX:
					return Input.GetAxisRaw(axis0[controllerIndex]);

				case Axis.LeftStickY:
					return Input.GetAxisRaw(axis1[controllerIndex]);

				case Axis.RightStickX:
					return Input.GetAxisRaw(axis3[controllerIndex]);

				case Axis.RightStickY:
					return Input.GetAxisRaw(axis4[controllerIndex]);

				case Axis.LT:
					return Input.GetAxisRaw(axis5[controllerIndex]);

				case Axis.RT:
					return Input.GetAxisRaw(axis6[controllerIndex]);

				case Axis.LTRT:
					return -Input.GetAxisRaw(axis5[controllerIndex]) + Input.GetAxisRaw(axis6[controllerIndex]);

				case Axis.DPadX:
					if (GetButton(Button.DPadRight, controllerIndex))
						return 1;
					else if (GetButton(Button.DPadLeft, controllerIndex))
						return -1;
					return 0;

				case Axis.DPadY:
					if (GetButton(Button.DPadUp, controllerIndex))
						return 1;
					else if (GetButton(Button.DPadDown, controllerIndex))
						return -1;
					return 0;
			}

			return 0;
		}

		public static bool GetButton(Button button, int controllerIndex)
		{
			switch (button)
			{
				case Button.A:
					return Input.GetKey(button16[controllerIndex]);

				case Button.B:
					return Input.GetKey(button17[controllerIndex]);

				case Button.X:
					return Input.GetKey(button18[controllerIndex]);

				case Button.Y:
					return Input.GetKey(button19[controllerIndex]);

				case Button.LB:
					return Input.GetKey(button13[controllerIndex]);

				case Button.RB:
					return Input.GetKey(button14[controllerIndex]);

				case Button.LT:
					return GetAxis(Axis.LT, controllerIndex) > 0.5f;

				case Button.RT:
					return GetAxis(Axis.RT, controllerIndex) > 0.5f;

				case Button.Back:
					return Input.GetKey(button10[controllerIndex]);

				case Button.Start:
					return Input.GetKey(button9[controllerIndex]);

				case Button.LS:
					return Input.GetKey(button11[controllerIndex]);

				case Button.RS:
					return Input.GetKey(button12[controllerIndex]);

				case Button.DPadDown:
					return Input.GetKey(button6[controllerIndex]);

				case Button.DPadUp:
					return Input.GetKey(button5[controllerIndex]);

				case Button.DPadLeft:
					return Input.GetKey(button7[controllerIndex]);

				case Button.DPadRight:
					return Input.GetKey(button8[controllerIndex]);

				case Button.LeftStickDown:
					return GetAxis(Axis.LeftStickY, controllerIndex) < -0.5f;

				case Button.LeftStickLeft:
					return GetAxis(Axis.LeftStickX, controllerIndex) < -0.5f;

				case Button.LeftStickRight:
					return GetAxis(Axis.LeftStickX, controllerIndex) > 0.5f;

				case Button.LeftStickUp:
					return GetAxis(Axis.LeftStickY, controllerIndex) > 0.5f;

				case Button.RightStickDown:
					return GetAxis(Axis.RightStickY, controllerIndex) < -0.5f;

				case Button.RightStickLeft:
					return GetAxis(Axis.RightStickX, controllerIndex) < -0.5f;

				case Button.RightStickRight:
					return GetAxis(Axis.RightStickX, controllerIndex) > 0.5f;

				case Button.RightStickUp:
					return GetAxis(Axis.RightStickY, controllerIndex) > 0.5f;
			}

			return false;
		}
#endif
	}
}

#pragma warning restore 0414

namespace Gypo.Input.Standalone.Editor
{
	using UnityEditor;
	using UnityEngine;

	// Fix for Unity 2019.3 not displaying KeyCodes as Enum Popups in the Inspector
	[CustomPropertyDrawer(typeof(Gamepad.Axis), true)]
	public class EditorGamepadAxis : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginChangeCheck();

			Gamepad.Axis key = (Gamepad.Axis)EditorGUI.EnumPopup(position, label, (Gamepad.Axis)property.intValue);

			if (EditorGUI.EndChangeCheck())
				property.intValue = (int)key;
		}
	}

	[CustomPropertyDrawer(typeof(Gamepad.Button), true)]
	public class EditorGamepadButton : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginChangeCheck();

			Gamepad.Button key = (Gamepad.Button)EditorGUI.EnumPopup(position, label, (Gamepad.Button)property.intValue);

			if (EditorGUI.EndChangeCheck())
				property.intValue = (int)key;
		}
	}
}