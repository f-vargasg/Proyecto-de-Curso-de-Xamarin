# Practica: Utilizando Glyph Icons

## Parte 1: Descargar Material Icons

1) Ir a https://materialdesignicons.com/ y descargar la fuente como Webfont
2) Descomprimir el .zip y copiar el archivo .ttf

## Parte 2 - Android: Add Glyph font
3) Agregar el .ttf al proyecto de Android dentro de la carpeta `Assets` en el directorio
4) Incluir el .ttf como `AndroidAsset` (clic derecho a Assets->Add->.ttf) en el proyecto `.Droid`

## Parte 3 - iOS: Add Glyph font
5) Agregar el .ttf al proyecto de iOS dentro de una (nueva) carpeta `Fonts`
6) Modificar el `info.plist` para incluir el .ttf como `UIAppFonts` -> Fonts/[nombre].ttf

info.plist -> Source -> Nueva entrada -> `Fonts provided by Application`

## Parte 4 - Forms: Use glyph icons 
7) Modificar el `App.xaml` para incluir el Font

```
<ResourceDictionary>
    <OnPlatform x:Key="MaterialFontFamily" x:TypeArguments="x:String">
        <On Platform="iOS" Value="Material Design Icons" />
        <On Platform="Android" Value="materialdesignicons-webfont.ttf#Material Design Icons" />
    </OnPlatform>
</ResourceDictionary>
```

8) Incluir un `StaticResource` en `App.xaml` para ser usado en la aplicacion

```
<FontImageSource x:Key="CarGlyph"
    FontFamily="{StaticResource MaterialFontFamily}"
    Glyph="{x:Static views:IconFont.Car}"
    Size="{OnPlatform iOS=40, Android=44}" />

```
### Generar la clase `IconFont.cs`
9) Ir a la pagina de [IconFont2Code](https://andreinitescu.github.io/IconFont2Code/) y generar la clase para el proyecto
10) Incluir el archivo en el proyecto de Forms `IconFont.cs`

### Parte 5 - Put everything together:
11) A partir del glyph definido como `StaticResource` utilizarlo como propiedad `Icon` o bien `Source` de las pantallas.

`Icon="{StaticResource PluginsGlyph}"` (atributo XAML)

12) Genere nuevos `StaticResource` con diferentes iconos para ser usados en la aplicacion

## Articulos de referencia y herramientas

- Hello Fonts (James): https://montemagno.com/using-font-icons-in-xamarin-forms-goodbye-images-hello-fonts/
- IconFont2Code: https://andreinitescu.github.io/IconFont2Code/
- Material Icons: https://materialdesignicons.com/
- iOS: https://devblogs.microsoft.com/xamarin/custom-fonts-in-ios/