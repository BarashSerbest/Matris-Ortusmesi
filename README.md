# Matris-Ortusmesi
5220505051 - Barash Serbest

  Bu algoritma, iki farklı 2D görüntüyü hizalamak için kullanılır. İki görüntü,
yani img1 ve img2, aynı boyutlarda olmalıdır ve her piksel sadece 0 veya 1 olabilir. 
İki görüntüdeki piksellerin dizilimi benzer olduğunda, iki görüntü birbirine hizalanmış olur.

  Algoritma, iki adımdan oluşuyor:

  Adım 1: img1 ve img2 girdi görüntülerinin boyutunu belirlenir. Bu adımda n boyutu,
her iki girdi görüntüsünün de n x n boyutunda olduğunu belirler.

  Adım 2: Tüm mümkün yönlerde img1 görüntüsünü kaydırarak img1 ve img2 arasındaki
benzerliği karşılaştırır. Benzerliğin hesaplanması, ComputeOverlap fonksiyonu
tarafından gerçekleşir. En iyi örtüşmenin hangi kaydırmada olduğunu bulmak için,
tüm mümkün kaydırma miktarları denenecek ve en yüksek örtüşme bulunacaktır.

En iyi örtüşmeyi bulduktan sonra, ShiftImage fonksiyonu kullanılarak img1 en iyi örtüşme 
ile img2'ye hizalanır. İki görüntü birbirine hizalandığında, img1 ve img2 çıktı olarak döndürülür.

Algoritma, optik karakter tanıma, görüntü işleme, tıp görüntüleme vb. alanlarda kullanılabilir.
