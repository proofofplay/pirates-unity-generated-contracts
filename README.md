## Pirates Unity Generated Contracts
This repo contains C# generated contracts for Pirate Nation game by Proof Of Play. It has a dependency on [pirates-web-ts](https://github.com/proofofplay/pirates-web-ts) repo to generate contracts and is used as a package for [Pirate Nation Unity client](https://github.com/proofofplay/pirates-unity)

## Binding Generation
This project assumes it is at the same level as [pirates-web-ts](https://github.com/proofofplay/pirates-web-ts). Please download the project and place it in the folder adjacent to this and run. 

# Pre-requisites

**Dependencies**:

1. Node (v16.x.x)
2. Yarn

The **_Strongly_ Recommended Setup**:

1. Go into Node folder.
2. Install (Homebrew](https://brew.sh/)
3. Use Homebrew to install NVM: `brew install nvm` (and follow the directions the command spits out)
4. Use NVM to install Node (v16): `nvm install 16`
5. Enable Yarn: `corepack enable`
6. Install project dependencies: `yarn install`

To generate new bindings run
`yarn generate-bindings`

This will generate all contract bindings with already hardhat generated contracts from [pirates-web-ts](https://github.com/proofofplay/pirates-web-ts) repo. The generated file are them placed into the Unity folder, but can be used by any C# project.

## Versioning and using as a package
The repo structure follows [Unity's recommended package structure](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@1.8/manual/index.html#advanced-package-topics). It should be noted, that it is recommended to update the version number every time the package gets updated from the generated files. To do so, package.json manifest version is updated.  
