# KullaniciGirisSistemi
Session kavramını anlamak için yaptığım uygulama

## Controllers

- AuthController: 
	- Login(Get): Kullanıcı girişi sayfasını açar.
	- Login(Post): Girilen Kullanıcıyı kontrol eder, Sessionda oluşturulmuş olan kullanıcılar listesinde girilen kullanıcıyı arar, var ise CurrentUser'a girilen kullanıcıyı atar ve oturum açılmış olur.
	- Logout: Sessiondaki currentUser'ı siler. Böylelikle mevcut kullanıcı olmadığından oturum kapatılmış olur.

- HomeController: Içerisinde Index ve private actionları var. index actionu eğer kullanıcı girişi yapılmamışsa **(** *session'da currentUser yok ise* **)** AuthController'ın login actionuna yönlendiriyor. Sessionda *currentUser* var ise modele atıp Index view'ini açıyor.

- InitController:  Runtime da kullanıcı oluşturmak için oluşturduk. İçerisinde sadece index action'u var. Database yerine kullanıcıları sessiona atadığımız yer burası. Home controller'in index action'una yönlendiriyor.

## Views

- Auth -> login: Kullanıcı adı ve parola girişi yapılıyor, girilen kullanıcı bulunamazsa **viewbag** ile gelen kullanıcı bulunamadı hatasını label etiketine yazar

- Home -> Index'te Mevcut kullanıcı adını ve şifreyi gösteriyor. Bu bilgiler model aracılığıyla geliyor. Auth controller'ın logout action'una yönlendiren bir buton var.
