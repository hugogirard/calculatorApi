You need to run the the following script to deploy this 

```Bash
#!/bin/bash
# Passed validation in Cloud Shell on 1/29/2024
# <FullScript>
# Create an App Service app with deployment from GitHub
#
# This sample script creates an app in App Service with
# its related resources. It then deploys your app code
# from a public GitHub repository (without continuous deployment).
# For GitHub deployment with continuous deployment, see 
# Create an app with continuous deployment from GitHub.
#
# set -e # exit if error
# Variable block
let "randomIdentifier=$RANDOM*$RANDOM"
location="East US"
resourceGroup="calculator-app-workshop-rg-$randomIdentifier"
tag="deploy-github.sh"
gitrepo=https://github.com/hugogirard/calculatorApi # Replace the following URL with your own public GitHub repo URL if you have one
appServicePlan="app-service-plan-workshop-$randomIdentifier"
webapp="calculator-api-$randomIdentifier"

# Create a resource group.
echo "Creating $resourceGroup in "$location"..."
az group create --name $resourceGroup --location "$location" --tag $tag

# Create an App Service plan in `BASIC` tier.
echo "Creating $appServicePlan"
az appservice plan create --name $appServicePlan --resource-group $resourceGroup --sku B1

# Create a web app.
echo "Creating $webapp"
az webapp create --name $webapp --resource-group $resourceGroup --plan $appServicePlan

# Deploy code from a public GitHub repository. 
az webapp deployment source config --name $webapp --resource-group $resourceGroup \
--repo-url $gitrepo --branch master --manual-integration

# Use curl to see the web app.
site="http://$webapp.azurewebsites.net"
echo $site
curl "$site" # Optionally, copy and paste the output of the previous command into a browser to see the web app
# </FullScript>

# echo "Deleting all resources"
# az group delete --name $resourceGroup -y
```
