Patika Profil Linki
`https://app.patika.dev/ouygun`
# Selection Sort Ödevi
[22,27,16,2,18,6] dizisinin selection sort'a göre aşamaları aşağıdaki şekilde gerçekleşir.

1. Önce veriler tek tek incelenerek en küçük veri tespit edilir ve en başa yazılır.

   `[22,27,16,2,18,6] -> [2,27,16,22,18,6]`
   
2. Sonrasında aynı işlemler ikinci üçüncü ve diğer elemanlar için tekrarlanır ve son aşamada sıralı dizi elde edilir.

    `[2,27,16,22,18,6] -> [2,6,16,22,18,27] -> [2,6,16,18,22,27]`

Gerçekleştirilen sıralama işlemi sırasında dizinin tüm elemanlarının tek tek gezilmesinden kaynaklı olarak Big-O notasyonu O(n²) olarak bulunur. 18 sayısı için gerçekleşecek senaryonun ise sayının ortada olması nedeniyle average case olacağı görülmektedir.

Ödevin ikinci aşamasında verilen [7,3,5,8,2,9,4,15,6] dizisinin selection sort'a göre sıralanmasının ilk 4 adımı ise aşağıda listelenmiştir:

1. [2,3,5,8,7,9,4,15,6]
2. [2,3,4,8,7,9,5,15,6]
3. [2,3,4,5,7,9,8,15,6]
4. [2,3,4,5,6,9,8,15,7] 

# Merge Sort Ödevi
[16,21,11,8,12,22] dizisinin Merge sort'a göre aşamaları aşağıda anlaşılırlığı artırmak amacıyla şematik olarak gösterilmiştir. Şemadan da görüleceği üzere sayılar arka arkaya bölünmüş daha sonra sıralanarak yeniden birleştirilmiş ve [8,11,12,16,21,22] şeklindeki sıralı dizi elde edilmiştir. Big-O Notasyonu ise O(n.logn)) şeklinde bulunmuştur.

![MergeSort](https://github.com/ouygun/patika-odevler/blob/main/verivealgoritma-odevleri/merge-sort.jpg?raw=true)

# Binary Search Tree Ödevi
[7,5,1,8,3,6,0,9,4,2] dizisinin binary search tree aşamaları aşağıdaki şekilde gösterilmiştir.
![BinarySearchTree](https://github.com/ouygun/patika-odevler/blob/main/verivealgoritma-odevleri/binary-search-tree.jpg?raw=true)

