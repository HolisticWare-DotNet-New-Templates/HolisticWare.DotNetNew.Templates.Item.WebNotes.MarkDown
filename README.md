# HolisticWare.DotNetNew.Templates.Item.WebNotes.MarkDown

HolisticWare.DotNetNew.Templates.Item.WebNotes.MarkDown

## Usage

```
dotnet new hw-markdown-topic --topic some-topic-to-write-about
```

verification:

```
tree
```

creates:

```
.
├── some-topic-to-write-about
│   ├── alternatives.md
│   ├── multimedia.md
│   ├── readme.md
│   ├── samples.md
│   └── tutorials.md
└── some-topic-to-write-about.md
```

## Installation 

### Local / Development

```
 dotnet new \
    uninstall \
        source/HolisticWare.DotNetNew.Templates.Item.WebNotes.MarkDown/content
        --force \
        -v:diagnostic

 dotnet new \
    install \
        source/HolisticWare.DotNetNew.Templates.Item.WebNotes.MarkDown/content \
        --force \
        -v:diagnostic
 ```

### NuGet local


### NuGet published



## Details

### `dotnet new` templating

https://github.com/moljac/HolisticWare.WebSite.Notes/tree/master/dotnet-netfx/core/dotnet-new-templates
