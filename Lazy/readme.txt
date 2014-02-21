こんにちは

設定がすんでいない人は、設定してください。
スクリーンショットを取るための設定です。何もしないとこのreadmeが表示されます。

[1]スクリーンショットソフトの準備

まず、好きなスクリーンショットソフトを用意してください。
ない人は、ひとまず、SnippingTool.exeというのがウィンドウズに最初から入っていると思うのでこれを用いてください。

スクリーンショットソフトが用意できたら、このフォルダに貼り付けてください。

[2]設定ファイルの変更

ImageViewerForTheLazy.exe.configというファイルがあります。これは設定の書いてあるファイルです。
これをテキストエディタで開いてください。

  <appSettings>
    <add key="ScreenShot" value="readme.txt"/>
  </appSettings>

と書いてある部分があります。この"readme.txt"を変更してください。
valueの値を用意されたスクリーンショットの実行ファイル名に変更してください。

  <appSettings>
    <add key="ScreenShot" value="SnippingTool.exe"/>
  </appSettings>

例えば、このように変更してください。もし、混ざるのがいや！などの理由で別のディレクトリに配置したいなら、


  <appSettings>
    <add key="ScreenShot" value="bin\SnippingTool.exe"/>
  </appSettings>

などのように書けば多分いけます。

起動時に何もないウィンドウが現れるのは仕様です･･･落ち着いたら直します。


[0]そもそも起動しないのですが･･･
.netフレームワークを用いています。最新版を導入したら動くと思います。
ウィンドウズ以外は知りません。