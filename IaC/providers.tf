terraform {
  required_providers {
    azurerm = {
      source = "hashicorp/azurerm"
      version = "4.57.0"
    }
  }
  backend "azurerm" {
    storage_account_name = "epsbookingiac1205"
    container_name = "epsbookingiac1205"
    resource_group_name = "rg_terraform_backend"
    key = "terraform.tfstate"
  }
}

provider "azurerm" {
    subscription_id = var.az_subscription_id
  features {

  }
  
}