# playgamespluginforunity
Unity NPM version of Google Play Games Plugin! This repository applies the same APACHE 2.0 license terms of the original version.

Original repo: https://github.com/playgameservices/play-games-plugin-for-unity

# current version
You can find at GooglePlayGames/PluginVersion.cs

# How to install
First ensure you have google ppa added into Packages/manifest.json:

```
"scopedRegistries": [
    {
        "name": "Game Package Registry by Google",
        "url": "https://unityregistry-pa.googleapis.com",
        "scopes": [
            "com.google"
        ]
    }
]
```

them, add external-dependency-manager into Packages/manifest.json:

> "com.google.external-dependency-manager": "1.2.160"

After this, you can add this package:

> "com.gameworkstore.playgamespluginforunity": "git://github.com/GameWorkstore/playgamespluginforunity.git"

The remaining steps follows the default tutorial for googleplaygames:

https://github.com/playgameservices/play-games-plugin-for-unity

# Contributions

If you are using this library and want to submit a change, go ahead! Overall, this project accepts contributions if:
- Is a bug fix;
- Or, is a generalization of a well-known issue;
- Or is performance improvement;
- Or is an improvement to already supported feature.

Also, you can donate to allow us to drink coffee while we improve it for you!