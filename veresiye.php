<?php
error_reporting(0);
$servername="localhost";
$username="root";
$password="";
$dbname="veresiye_kayit";

$conn=new mysqli($servername,$username,$password,$dbname);
$new=mysqli_set_charset($conn,"utf8");

if($conn->connect_error)
{
   die("Bağlantı Hatası: ".$conn->connect_error);
}
else
{
    //echo "Bağlantı Başarılı.".";";
}


if($_REQUEST['komut']=='yolla')
{
    $ad_soyad = $_POST["ad_soyad"];
    $telefon = $_POST["telefon"];
    $emanet_bugday = $_POST["emanet_bugday"];
    $toplam_borc = $_POST["toplam_borc"];

    $sql = "INSERT INTO kisiler (ad_soyad,telefon,emanet_bugday,toplam_borc)
    VALUES ('$ad_soyad','$telefon','$emanet_bugday','$toplam_borc')";

    if($conn->query($sql) === TRUE)
    {
        echo "Yeni kayıt eklendi.";
    }
    else
    {
        echo "Hata!: " . $sql . "<br>" . $conn->error;
    }
}

if($_REQUEST['komut']=='al')
{
    $bul="SELECT * FROM kisiler";
    $kayit=$conn->query($bul);

    if($kayit->num_rows>0)
    {
        while($satir=$kayit->fetch_assoc())
        {
            echo $satir["id"].";";
            echo $satir["ad_soyad"].";";
            echo $satir["telefon"].";";
            echo $satir["emanet_bugday"].";";
            echo $satir["toplam_borc"].";";
        }
    }   
}

if($_REQUEST['komut']=='sil')
{
    $id = $_POST["id"];
    $ad_soyad = $_POST["ad_soyad"];
    $telefon = $_POST["telefon"];

    $sql = "DELETE FROM kisiler WHERE id=$id";

    if($conn->query($sql) === TRUE)
    {
        echo "Kayıt silindi.";

        $sql2 = "DROP TABLE tbl_$ad_soyad$telefon";

        if($conn->query($sql2) === TRUE)
        {
            echo "İlgili tablo silindi.";
        }
        else
        {
            echo "Hata!: " . $sql . "<br>" . $conn->error;
        }
    }
    else
    {
        echo "Hata!: " . $sql . "<br>" . $conn->error;
    }
}

if($_REQUEST['komut']=='ara')
{
    $isim = $_POST["isim"];

    $bul="SELECT * FROM kisiler WHERE ad_soyad LIKE '%$isim%'";
    $kayit=$conn->query($bul);

    if($kayit->num_rows>0)
    {
        while($satir=$kayit->fetch_assoc())
        {
            echo $satir["id"].";";
            echo $satir["ad_soyad"].";";
            echo $satir["telefon"].";";
            echo $satir["emanet_bugday"].";";
            echo $satir["toplam_borc"].";";
        }
    }   
}

if($_REQUEST['komut']=='tablo')
{
    $ad_soyad=$_POST["ad_soyad"];
    $telefon=$_POST["telefon"];

    $sql = "CREATE TABLE tbl_$ad_soyad$telefon (
        id int AUTO_INCREMENT primary key NOT NULL,
        alan varchar(255),
        alinan varchar(255),
        alinan_sayisi int(11),
        tutar int(11),
        tarih varchar(255)
    )";

    if($conn->query($sql) === TRUE)
    {
        echo "Yeni tablo eklendi.";
    }
    else
    {
        echo "Hata!: " . $sql . " " . $conn->error;
    }
}

if($_REQUEST['komut']=='isim_telefon')
{
    $id=$_POST["id"];
    
    $bul="SELECT * FROM kisiler WHERE id=$id";
    $kayit=$conn->query($bul);

    if($kayit->num_rows>0)
    {
        while($satir=$kayit->fetch_assoc())
        {
            echo $satir["id"].";";
            echo $satir["ad_soyad"].";";
            echo $satir["telefon"].";";
        }
    }   
}

if($_REQUEST['komut']=='ekle')
{
    $ad_soyad=$_POST["ad_soyad"];
    $telefon=$_POST["telefon"];
    $alan=$_POST["alan"];
    $alinan=$_POST["alinan"];
    $alinan_sayi=$_POST["alinan_sayi"];
    $tutar=$_POST["tutar"];
    $tarih=$_POST["tarih"];

    $sql = "INSERT INTO tbl_$ad_soyad$telefon (alan,alinan,alinan_sayisi,tutar,tarih)
    VALUES ('$alan','$alinan','$alinan_sayi','$tutar','$tarih')";

    if($conn->query($sql) === TRUE)
    {
        echo "Yeni kayıt eklendi.";
    }
    else
    {
        echo "Hata!: " . $sql . "<br>" . $conn->error;
    }
}

if($_REQUEST['komut']=='borc')
{
    $ad_soyad=$_POST["ad_soyad"];
    $telefon=$_POST["telefon"];

    $bul="SELECT * FROM tbl_$ad_soyad$telefon";
    $kayit=$conn->query($bul);

    if($kayit->num_rows>0)
    {
        while($satir=$kayit->fetch_assoc())
        {
            echo $satir["tutar"].";";
        }
    }
}

if($_REQUEST['komut']=='borc_yolla')
{
    $id=$_POST["id"];
    $toplam_borc=$_POST["toplam_borc"];

    $sql = "UPDATE kisiler
    SET toplam_borc='$toplam_borc'
    WHERE id=$id";

    if($conn->query($sql) === TRUE)
    {
        echo "Yeni kayıt eklendi.";
    }
    else
    {
        echo "Hata!: " . $sql . "<br>" . $conn->error;
    }
}

?>