resource "azurerm_mssql_server" "eps-booking-database" {
  name                         = "eps-booking-database-0512"
  resource_group_name          = azurerm_resource_group.rg_eps_booking.name
  location                     = azurerm_resource_group.rg_eps_booking.location
  administrator_login          = var.admin_username
  administrator_login_password = var.admin_password
  version                      = "12.0"
}

resource "azurerm_mssql_firewall_rule" "example" {
  name             = "myip"
  server_id        = azurerm_mssql_server.eps-booking-database.id
  start_ip_address = "181.51.32.102"
  end_ip_address   = "181.51.32.102"
}

resource "azurerm_mssql_database" "db" {
  name      = "eps_booking_db"
  server_id = azurerm_mssql_server.eps-booking-database.id
  sku_name = "Basic"
  geo_backup_enabled = false
  
}