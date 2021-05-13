//Test.cs
az acr create --resource-group myResourceGroup --name rajan --sku Basic
az acr list --resource-group myResourceGroup --query "[].{acrLoginServer:loginServer}" --output json
az acr login --name sriniiyer
docker tag mcr.microsoft.com/azuredocs/azure-vote-front:v1 rajanchoudhary.azurecr.io/azure-vote-front:v1
docker push rajanchoudhary.azurecr.io/azure-vote-front:v1 
