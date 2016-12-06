# OcrSample
OCRの読み取り処理のサンプル

・Nugetしただけだと以下のような例外が発生する。
Patagames.Ocr.Exceptions.LanguageNotFoundException: The requested language 'jpn'
 not found in tessdata folder 'C:\pj\Test\OcrSample\OcrSample\bin\Release\tessda
ta'. Please download it from http://tesseract.patagames.com/langs/ and put into
the tessdata folder.

なので、https://tesseract.patagames.com/langs/へアクセスし、
それ用の辞書ファイル？をDL
これでできるようにはなる。


・ただ、幅がデカい画像だとアウトっぽい。
Patagames.Ocr.Exceptions.NoLicenseException: The requested operation cannot be c
ompleted due to a license restrictions. With the trial version the images which
width is smaller than 500 pixels can be loaded without any restrictions. For oth
er images the allowed widths is 500 - 550 pixels; 600 - 650 pixels; 700 - 750 pi
xels and so on.

ただ、よくわからないのは、幅が940ピクセルのが大丈夫で、888ピクセルのが例外になる。。
900-950の間だと平気なのか？

・あと、よくわからないけど、末尾に\n\nが付く。
縦サイズの問題なのかもしれない。


