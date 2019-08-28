# Curso de Xamarin

## Contacto
Esteban Solano @stvansolano 
- Email: stvansolano@outlook.com 
- Blog: http://stvansolano.github.io/blog

## Proximos Pasos

1) Configurar VS2017 + Xamarin
2) Bajar el codigo de GitHub (boton verde)
3) Crear un usuario de GitHub en [la pagina de registro](https://github.com/join)

## Lins de referencia

### Sesion-01

- https://www.apple.com/apple-events/june-2019/
- Instalación Xamarin](https://stvansolano.github.io/2018/08/30/Guia-de-instalacion-Xamarin-y-herramientas-recomendadas/)
- https://www.apple.com/apple-events/june-2019/
- https://events.google.com/io/
- https://docs.microsoft.com/en-us/xamarin/get-started/installation/windows

## Sesion-02
http://stvansolano.github.io/2016/10/31/Como-desplegar-apps-para-Android-en-tu-dispositivo-fisico/

http://vysor.io/

https://docs.microsoft.com/en-us/xamarin/tools/live-player/

https://www.android.com/history/#/marshmallow

## Apendice: Comandos y guias de Git

http://rogerdudler.github.io/git-guide/

1) cd [carpeta del proyecto]
2) git init (iniciar Git en la carpeta)
3) git status (ver el estado de los archivos)
4) git add -A (agregar todos los archivos)
5) git commit -m "Primer commit"
6) git remote add origin https://github.com/stvansolano/curso-xamarin.git
7) git push origin master -f

Xamarin.Forms en Git: https://github.com/xamarin/Xamarin.Forms

## Sesion-03

* Comandos vrs eventos
* XAML vrs C#
* ContentPage vrs Content (`View`)
* Bindings => `{Binding Text, Source={x:Reference entryNombre}}` No necesita C#!
* Material de referencia: [Xamarin.Forms](https://docs.microsoft.com/es-ES/xamarin/xamarin-forms/xaml/xaml-basics/)
* XAML-C (Xaml compilation)

 `[assembly: XamlCompilation (XamlCompilationOptions.Compile)]`

 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8
 - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version

 ## Sesion-04

 - Uso de `NavigationPage` en el `App.xaml.cs` (`NavigationPage.SetHasNavigationBar(this, false)`)
 - Uso de `Navigation` / `PushAsync` en los click
 - Uso de `Command` vrs `Clicked`
 - Uso de `Device.RuntimePlatform` y `Device` (plataformas)
 - Paso de parametros entre pantallas

 ## Sesion-05

 - Platform-specific XAML
 - Colecciones en .NET / Xamarin
 - ListView

 ## ListView (Sin Forms) 

iOS - https://docs.microsoft.com/en-us/xamarin/ios/user-interface/controls/tables/populating-a-table-with-data
Android - https://docs.microsoft.com/en-us/xamarin/android/user-interface/layouts/list-view/

## Iconos

 https://material.io/

 https://iconos8.es/

 https://developer.android.com/guide/practices/screens_support?hl=es-419#range 
 
## Sesion-06

#### Uso de Web-Services (RESTful APIs)

https://www.getpostman.com/

http://json2csharp.com/

https://jsonlint.com/

 Uso de FontImageSource
 
 ### Styling
 
 Explicit styling
 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/styles/xaml/explicit
 
 ### CSS styling in Xamarin.Forms
 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/styles/css/

 ## Sesion-07 - ListView y Web Services (JSON.NET)

 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/listview/customizing-cell-appearance

 https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/string-formatting

 https://www.newtonsoft.com/json/help/html/SerializationAttributes.htm

## Sesion - 08 - SQLite

https://docs.microsoft.com/en-us/xamarin/xamarin-forms/data-cloud/data/databases

https://realm.io/docs/dotnet/latest
