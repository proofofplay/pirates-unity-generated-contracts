const fs = require("fs");
const codegen = require("nethereum-codegen");

const allowedNetwork = 'maticmum'
const basePath = `./../Runtime/Contracts`;
const hardhat_contracts = "../../pirates-web-ts/packages/vite-app-ts/src/generated/contracts/hardhat_contracts.json";
const contractPath = `../../pirates-web-ts/packages/hardhat-ts/generated/deployments/${allowedNetwork}`;
const addressesPath = './../Runtime/addresses.json';

const generateBinding = (contractName, contractJson) => {
  const baseNamespace = "PirateNationContracts";
  const projectName = "PirateNationContracts.csproj";

  //get bytecode.
  const generatedJson = JSON.parse(fs.readFileSync(`${contractPath}/${contractName}.json`));

  //CSharp 0, Vb.Net 1, FSharp 3
  codegen.generateNetStandardClassLibrary(projectName, basePath, 0);

  //CSharp 0, Vb.Net 1, FSharp 3
  codegen.generateAllClasses(
    JSON.stringify(contractJson.abi, null, 2),
    generatedJson.bytecode,
    contractName,
    baseNamespace,
    basePath,
    0
  );

  console.log("generated c# bindings for contract: ", contractName);
};

async function main() {
  const contracts = JSON.parse(fs
    .readFileSync(hardhat_contracts)
    .toString());

    const networks = [...Object.values(contracts).flat()];

    let addresses = {};
    for (const network of networks) {
      if (network.name === allowedNetwork) {
        for (const contract of Object.keys(network.contracts)) {
          generateBinding(contract, network.contracts[contract]);
        }
      }

      addresses[network.name] = {};
      
      for (const contract of Object.keys(network.contracts)) {
        addresses[network.name][contract] = network.contracts[contract].address;
      }
    }
    fs.writeFileSync(addressesPath, JSON.stringify(addresses, null, 2));
  console.log("Successfully generated bindings");
}
main()
  .then(() => process.exit(0))
  .catch((error) => {
    console.error(error);
    process.exit(1);
  });
