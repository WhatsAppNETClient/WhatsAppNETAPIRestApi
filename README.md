# WhatsApp NET API Rest Api

Ini adalah contoh pembuatan layanan WhatsApp REST API menggunakan libray WhatsApp Client .NET

## Persyaratan Sistem

* Windows 8, 10 dan windows versi terbaru
* .NET Framework 4.5 dan .NET versi terbaru
* Node.js versi 14.16.x atau versi terbaru
* [Software git](https://git-scm.com/downloads) (version control)

## Petunjuk Instalasi

Bisa Anda cek di http://wa-net.coding4ever.net/#instalasi

## Catatan Build Production

Secara default untuk keperluan development, layanan REST API bisa di akses di alamat: http://localhost:5555/. Untuk keperluan production Anda harus merubah kode berikut:

```
if (chkRestAPIService.Checked)
{
    var url = "http://localhost";
    var port = "5555";

    _waRestService.Start(url, port);
}
else
    _waRestService.Stop();
```

menjadi

```
if (chkRestAPIService.Checked)
{
    var url = "http://*"; // penyesuaian di sini
    var port = "5555";

    _waRestService.Start(url, port);
}
else
    _waRestService.Stop();
```

Setelah itu jalankan perintah berikut melalui command prompt (as administrator)

`netsh http add urlacl url=http://+:5555/ user=everyone`

## Layanan REST API yang tersedia

* Send Message
  - sendText
  - sendImage
  - sendFile
  - sendMediaFromUrl
  - sendLocation
  - sendList
  - sendButton
* Message
  - unreadMessages
  - allMessagesByContact
* Archive/Delete Chat
  - archiveChat
  - archiveChatByContact
  - deleteChat
  - deleteChatByContact
* Set Status
  - setStatus
  - setStatusPlusImage
  - setStatusPlusImageFromUrl
* Contact/Group
  - contacts
  - groups
* System
  - waNumber
  - batteryStatus