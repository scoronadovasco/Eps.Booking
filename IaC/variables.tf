variable "az_subscription_id" {
  type = string
  default = "34820a7f-49a4-448c-adab-ee7b09d9403b"
}

variable "admin_username" {
  type = string
  sensitive = true

}

variable "admin_password" {
  type = string
  sensitive = true
}