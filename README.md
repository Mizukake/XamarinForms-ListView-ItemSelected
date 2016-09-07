# ListView/ItemSelected

## やりたかったこと
* リストを選んだ時に、選択中のハイライトを表示したままにしたくなかった。
* x:Nameは絶対つかない。


## 悩んだこと
* SelectItemをnullにしたけど、何故かハイライト残ったまま！

## 解決法
* XAMLのSelectedItemにMode=TwoWayを設定
