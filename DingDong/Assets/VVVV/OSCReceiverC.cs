using UnityEngine;

/*
OSC RECEIVER C#
A modified version of this plugin - https://github.com/heaversm/unity-osc-receiver
*/

[RequireComponent(typeof(Osc))]
[RequireComponent(typeof(UDPPacketIO))]
public class OSCReceiverC : MonoBehaviour {
  #region Variables
  [SerializeField] private string     remoteIP        = "127.0.0.1";
  [SerializeField] private int        listenerPort    = 8000;
  [SerializeField] private int        senderPort      = 9000;
  private Osc                         handler;

  public static int                   OSCcount        = 32;
  public static float[]               OSCvalues       = new float[OSCcount];

  Texture2D texture2D;
  Color[] colors;
  #endregion

  #region Monobehaviour Methods
  void Awake ()
  {
    texture2D = new Texture2D(OSCcount, 1);
    colors = new Color[OSCcount];
    for (int i = 0; i < OSCcount; i++) {
      colors[i] = new Color(1f, 1f, 1f, 1f);
    }
    texture2D.SetPixels(colors);
    Shader.SetGlobalTexture("_TextureFFT", texture2D);
  }

  void Start () {
    UDPPacketIO udp = GetComponent<UDPPacketIO>();
    udp.init(remoteIP, senderPort, listenerPort);
    handler = GetComponent<Osc>();
    handler.init(udp);
    handler.SetAllMessageHandler(MessageHandler);
  }
  #endregion

  #region Methods
  // called every time Unity receives a message
  public void MessageHandler(OscMessage message) {
    string msgString = Osc.OscMessageToString(message);

    for (int i = 0; i < OSCcount; i++) {
      OSCvalues[i] = float.Parse(message.Values[i].ToString());
    }
  }

  void Update ()
  {
      float fft = 0f;
      for (int i = 0; i < OSCcount; i++) {
        fft = Mathf.Clamp(OSCvalues[i], 0f, 1f);
        colors[i] = new Color(fft, fft, fft, 1f);
      }
      texture2D.SetPixels(colors);
      texture2D.Apply(false);
  }
  #endregion
}
