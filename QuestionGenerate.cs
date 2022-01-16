using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
   public static string actualAnswer;
   public static bool displayingQuestion = false;
   public int questionNumber;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true ; 
            questionNumber = Random.Range(1, 11);
            if (questionNumber == 1)
            {
               
                QuestionDisplay.newQuestion = "Benda yang sama seperti PC tapi kecil dan mudah dibawa ?";
                QuestionDisplay.newA = "A. Laptop";
                QuestionDisplay.newB = "B. XBOX";
                QuestionDisplay.newC = "C. CPU";
                QuestionDisplay.newD = "D. PS5";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
             {
                 
                 QuestionDisplay.newQuestion = "Berikut pejuang proklamasi Indonesia kecuali ?";
                 QuestionDisplay.newA = "A. Ir. Soekarno";
                 QuestionDisplay.newB = "B. Achmad Soebardjo,";
                 QuestionDisplay.newC = "C. Moh. Hatta";
                 QuestionDisplay.newD = "D. Hasanudin";
                 actualAnswer = "D";
            }

             if (questionNumber == 3)
             {
                  
                 QuestionDisplay.newQuestion = " Fungsi rongga rantai pada bunga teratai adalah membawa oksigen ke ?";
                 QuestionDisplay.newA = "A. daun";
                 QuestionDisplay.newB = "B. batang dan akar";
                 QuestionDisplay.newC = "C. batang";
                 QuestionDisplay.newD = "D. bunga";
                 actualAnswer = "B";
            }

             if (questionNumber == 4)
             {
                 
                 QuestionDisplay.newQuestion = " Suatu jaringan komputer yang menghubungkan suatu komputer dengan komputer lain dengan jarak yang terbatas disebut dengan ?";
                 QuestionDisplay.newA = "A. LAN";
                 QuestionDisplay.newB = "B. WAN";
                 QuestionDisplay.newC = "C. MAN";
                 QuestionDisplay.newD = "D. CAN";
                 actualAnswer = "A";
            }

            if (questionNumber == 5)
             {
                 
                 QuestionDisplay.newQuestion = " E-business adalah kegiatan bisnis ? ";
                 QuestionDisplay.newA = "A. penjualan";
                 QuestionDisplay.newB = "B. ruko";
                 QuestionDisplay.newC = "C. internet";
                 QuestionDisplay.newD = "D. rumah";
                 actualAnswer = "C";
            }

            if (questionNumber == 6)
             {
                
                 QuestionDisplay.newQuestion = " bilangan octal adalah bilangan yang memiliki basis ? ";
                 QuestionDisplay.newA = "A. 2";
                 QuestionDisplay.newB = "B. 9";
                 QuestionDisplay.newC = "C. 8";
                 QuestionDisplay.newD = "D. 16";
                 actualAnswer = "C";
            }

            if (questionNumber == 7)
             {
                 
                 QuestionDisplay.newQuestion = " Sebutkan yang termasuk sistem bilangan ? ";
                 QuestionDisplay.newA = "A. Desimal";
                 QuestionDisplay.newB = "B. Ganjil";
                 QuestionDisplay.newC = "C. Genap";
                 QuestionDisplay.newD = "D. Satuan";
                 actualAnswer = "A";
            }

            if (questionNumber == 8)
             {
                 
                 QuestionDisplay.newQuestion = " Berbeda-beda tapi tetap satu merupakan pengamalan nilai pancasila sila ? ";
                 QuestionDisplay.newA = "A. Kelima";
                 QuestionDisplay.newB = "B. pertama";
                 QuestionDisplay.newC = "C. Keempat";
                 QuestionDisplay.newD = "D. Ketiga";
                 actualAnswer = "D";
            }

            if (questionNumber == 9)
             {
                
                 QuestionDisplay.newQuestion = " kalimat yang mengandung gagasan pembicara/penulis yang terdiri atas kata-kata yang mempunyai unsur SPOK disebut Kalimat ? ";
                 QuestionDisplay.newA = "A. Efektif";
                 QuestionDisplay.newB = "B. Pasif";
                 QuestionDisplay.newC = "C. Aktif";
                 QuestionDisplay.newD = "D. Deduktif";
                 actualAnswer = "A";
            }

            if (questionNumber == 10)
             {
                 
                 QuestionDisplay.newQuestion = " Suatu cara hewan beradaptasi dimana warna tubuhnya sesuai dengan tempat yang iya singgahi, dengan tujuan untuk melindungi diri disebut ? ";
                 QuestionDisplay.newA = "A. Higrofit";
                 QuestionDisplay.newB = "B. Mimikri";
                 QuestionDisplay.newC = "C. Xerofit";
                 QuestionDisplay.newD = "D. Hidrofit";
                 actualAnswer = "B";
            }

            QuestionDisplay.pleaseUpdate = false;

        }
        
    }
}
