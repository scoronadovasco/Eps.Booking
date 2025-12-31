variable "az_subscription_id" {
  type = string
  default = "ef0daded-79da-4cd0-ba63-e41e85e065d6"
}

variable "admin_username" {
  type = string
  sensitive = true

}

variable "admin_password" {
  type = string
  sensitive = true
}