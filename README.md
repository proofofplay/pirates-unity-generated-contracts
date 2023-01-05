## Pirates Unity Generated Contracts
This repo contains C# generated contracts for Pirate Nation game by Proof Of Play. It has a dependency on [pirates-web-ts](https://github.com/proofofplay/pirates-web-ts) repo to generate contracts and is used as a package for [Pirate Nation Unity client](https://github.com/proofofplay/pirates-unity)
This project assumes it is at the same level as [pirates-web-ts](https://github.com/proofofplay/pirates-web-ts). Please download the project and place it in the folder adjacent to this and run.

`yarn generate-bindings`

## Versioning and using as a package
The repo structure follows [Unity's recommended package structure](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@1.8/manual/index.html#advanced-package-topics). It should be noted, that it is recommended to update the version number every time the package gets updated from the generated files. To do so, package.json manifest version is updated.  
