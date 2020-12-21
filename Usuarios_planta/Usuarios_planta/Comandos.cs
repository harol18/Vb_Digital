using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using MySql.Data.MySqlClient;


namespace Usuarios_planta
{
    class Comandos
    {
        //MySqlConnection con = new MySqlConnection("server=82.2.121.99;Uid=userapp;password=userapp;database=dblibranza;port=3306;persistsecurityinfo=True;");
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=Indr42020$;database=dblibranza;port=3306;persistsecurityinfo=True;");

        public void Guardar_vobo(TextBox TxtRadicado, TextBox TxtCedula_Cliente, TextBox TxtNombre_Cliente, TextBox TxtScoring, ComboBox cmbFuerza_Venta, TextBox TxtCodigo_Convenio,ComboBox cmbDirigido, TextBox TxtCod_Matriz, TextBox TxtConsecutivo, 
                                 ComboBox cmbGrado, TextBox TxtCod_Militar1, TextBox TxtCod_Militar2, ComboBox cmbDestino, TextBox TxtSubproducto, TextBox TxtTasa_E_A, TextBox TxtTasa_N_M, 
                                  TextBox TxtMonto_Aprobado, TextBox TxtPlazo_Aprobado, TextBox TxtValor_Cuota, TextBox TxtTotal_Credito, TextBox TxtMonto_Letras, TextBox TxtTotal_Letras, TextBox TxtCartera1, 
                                  TextBox TxtCartera2, TextBox TxtCartera3, TextBox TxtCartera4, DateTimePicker dtpFecha_Envio, ComboBox cmbCorte_Envio, DateTimePicker dtpHora_Envio, DateTimePicker dtpFecha_Posible_Rta, 
                                  DateTimePicker dtpFecha_Restriccion, ComboBox cmbEstado_Operacion, ComboBox cmbTipologia, ComboBox TxtEstado_Correo, ComboBox TtxRespuesta_Correo, DateTimePicker dtpFecha_Cierre_Etapa, 
                                  TextBox TxtComentarios)
        {
            con.Open(); 
            MySqlCommand cmd = new MySqlCommand("guardar_vobo", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Radicado", TxtRadicado.Text);
                cmd.Parameters.AddWithValue("@_Cedula_Cliente", TxtCedula_Cliente.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Cliente", TxtNombre_Cliente.Text);
                cmd.Parameters.AddWithValue("@_Scoring", TxtScoring.Text);
                cmd.Parameters.AddWithValue("@_Fuerza_Venta", cmbFuerza_Venta.Text);
                cmd.Parameters.AddWithValue("@_Codigo_Convenio", TxtCodigo_Convenio.Text);
                cmd.Parameters.AddWithValue("@_Dirigido", cmbDirigido.Text);
                cmd.Parameters.AddWithValue("@_Cod_Matriz", TxtCod_Matriz.Text);
                cmd.Parameters.AddWithValue("@_Consecutivo", TxtConsecutivo.Text);               
                cmd.Parameters.AddWithValue("@_Grado", cmbGrado.Text);
                cmd.Parameters.AddWithValue("@_Cod_Militar1", TxtCod_Militar1.Text);
                cmd.Parameters.AddWithValue("@_Cod_Militar2", TxtCod_Militar2.Text);                
                cmd.Parameters.AddWithValue("@_Destino", cmbDestino.Text);
                cmd.Parameters.AddWithValue("@_Subproducto", TxtSubproducto.Text);
                cmd.Parameters.AddWithValue("@_Tasa_E_A", TxtTasa_E_A.Text);
                cmd.Parameters.AddWithValue("@_Tasa_N_M", TxtTasa_N_M.Text);
                cmd.Parameters.AddWithValue("@_Monto_Aprobado", string.Format("{0:#}", double.Parse(TxtMonto_Aprobado.Text)));
                cmd.Parameters.AddWithValue("@_Plazo_Aprobado", TxtPlazo_Aprobado.Text);
                cmd.Parameters.AddWithValue("@_Valor_Cuota", string.Format("{0:#}", double.Parse(TxtValor_Cuota.Text)));
                cmd.Parameters.AddWithValue("@_Total_Credito", string.Format("{0:#}", double.Parse(TxtTotal_Credito.Text)));
                cmd.Parameters.AddWithValue("@_Monto_Letras", TxtMonto_Letras.Text);
                cmd.Parameters.AddWithValue("@_Total_Letras", TxtTotal_Letras.Text);
                cmd.Parameters.AddWithValue("@_Cartera1", TxtCartera1.Text);
                cmd.Parameters.AddWithValue("@_Cartera2", TxtCartera2.Text);
                cmd.Parameters.AddWithValue("@_Cartera3", TxtCartera3.Text);
                cmd.Parameters.AddWithValue("@_Cartera4", TxtCartera4.Text);
                cmd.Parameters.AddWithValue("@_Fecha_Envio", dtpFecha_Envio.Text);
                cmd.Parameters.AddWithValue("@_Corte_Envio", cmbCorte_Envio.Text);
                cmd.Parameters.AddWithValue("@_Hora_Envio", dtpHora_Envio.Text);
                cmd.Parameters.AddWithValue("@_Fecha_Posible_Rta", dtpFecha_Posible_Rta.Text);
                cmd.Parameters.AddWithValue("@_Fecha_Restriccion", dtpFecha_Restriccion.Text);
                cmd.Parameters.AddWithValue("@_Estado_Operacion", cmbEstado_Operacion.Text);
                cmd.Parameters.AddWithValue("@_Tipologia", cmbTipologia.Text);
                cmd.Parameters.AddWithValue("@_Estado_Correo", TxtEstado_Correo.Text);
                cmd.Parameters.AddWithValue("@_Respuesta_Correo", TtxRespuesta_Correo.Text);
                cmd.Parameters.AddWithValue("@_Fecha_Cierre_Etapa", dtpFecha_Cierre_Etapa.Text);
                cmd.Parameters.AddWithValue("@_Comentarios", TxtComentarios.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Almacenada con Éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            catch (Exception ex)
            {
                myTrans.Rollback();                
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Buscar_vobo(TextBox TxtRadicado, TextBox TxtCedula_Cliente, TextBox TxtNombre_Cliente, TextBox TxtScoring, ComboBox cmbFuerza_Venta, TextBox TxtCodigo_Convenio, ComboBox cmbDirigido, TextBox TxtCod_Matriz, TextBox TxtConsecutivo,
                                ComboBox cmbGrado, TextBox TxtCod_Militar1, TextBox TxtCod_Militar2, ComboBox cmbDestino, TextBox TxtSubproducto, TextBox TxtTasa_E_A, TextBox TxtTasa_N_M,
                                TextBox TxtMonto_Aprobado, TextBox TxtPlazo_Aprobado, TextBox TxtValor_Cuota, TextBox TxtTotal_Credito, TextBox TxtMonto_Letras, TextBox TxtTotal_Letras, TextBox TxtCartera1,
                                TextBox TxtCartera2, TextBox TxtCartera3, TextBox TxtCartera4, DateTimePicker dtpFecha_Envio, ComboBox cmbCorte_Envio, DateTimePicker dtpHora_Envio, DateTimePicker dtpFecha_Posible_Rta,
                                DateTimePicker dtpFecha_Restriccion, ComboBox cmbEstado_Operacion, ComboBox cmbTipologia, ComboBox TxtEstado_Correo, ComboBox TtxRespuesta_Correo, DateTimePicker dtpFecha_Cierre_Etapa,
                                TextBox TxtComentarios)
        {          
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("buscar_vobo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Radicado", TxtRadicado.Text);
                MySqlDataReader registro;
                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    TxtCedula_Cliente.Text = registro["Cedula_Cliente"].ToString();
                    TxtNombre_Cliente.Text = registro["Nombre_Cliente"].ToString();
                    TxtScoring.Text = registro["Scoring"].ToString();
                    cmbFuerza_Venta.Text = registro["Fuerza_Venta"].ToString();
                    TxtCodigo_Convenio.Text = registro["Codigo_Convenio"].ToString();
                    cmbDirigido.Text = registro["Dirigido"].ToString();
                    TxtCod_Matriz.Text = registro["Cod_Matriz"].ToString();
                    TxtConsecutivo.Text = registro["Consecutivo"].ToString();                    
                    cmbGrado.Text = registro["Grado"].ToString();
                    TxtCod_Militar1.Text = registro["Cod_Militar1"].ToString();
                    TxtCod_Militar2.Text = registro["Cod_Militar2"].ToString();
                    cmbDestino.Text = registro["Destino"].ToString();
                    TxtSubproducto.Text = registro["Subproducto"].ToString();
                    TxtTasa_E_A.Text = registro["Tasa_E_A"].ToString();
                    TxtTasa_N_M.Text = registro["Tasa_N_M"].ToString();
                    TxtMonto_Aprobado.Text = registro["Monto_Aprobado"].ToString();
                    TxtPlazo_Aprobado.Text = registro["Plazo_Aprobado"].ToString();
                    TxtValor_Cuota.Text = registro["Valor_Cuota"].ToString();
                    TxtTotal_Credito.Text = registro["Total_Credito"].ToString();
                    TxtMonto_Letras.Text = registro["Monto_Letras"].ToString();
                    TxtTotal_Letras.Text = registro["Total_Letras"].ToString();
                    TxtCartera1.Text = registro["Cartera1"].ToString();
                    TxtCartera2.Text = registro["Cartera2"].ToString();
                    TxtCartera3.Text = registro["Cartera3"].ToString();
                    TxtCartera4.Text = registro["Cartera4"].ToString();
                    dtpFecha_Envio.Text = registro["Fecha_Envio"].ToString();
                    cmbCorte_Envio.Text = registro["Corte_Envio"].ToString();
                    dtpHora_Envio.Text = registro["Hora_Envio"].ToString();
                    dtpFecha_Posible_Rta.Text = registro["Fecha_Posible_Rta"].ToString();
                    dtpFecha_Restriccion.Text = registro["Fecha_Restriccion"].ToString();
                    cmbEstado_Operacion.Text = registro["Estado_Operacion"].ToString();
                    cmbTipologia.Text = registro["Tipologia"].ToString();
                    TxtEstado_Correo.Text = registro["Estado_Correo"].ToString();
                    TtxRespuesta_Correo.Text = registro["Respuesta_Correo"].ToString();
                    dtpFecha_Cierre_Etapa.Text = registro["Fecha_Cierre_Etapa"].ToString();
                    TxtComentarios.Text = registro["Comentarios"].ToString();
                    con.Close();
                }else
                {
                    MessageBox.Show("Caso no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    TxtCedula_Cliente.Text = null;
                    TxtNombre_Cliente.Text = null;
                    TxtScoring.Text = null;
                    cmbFuerza_Venta.Text = null;
                    TxtCodigo_Convenio.Text = null;
                    cmbDirigido.Text = null;
                    TxtConsecutivo.Text = null;                   
                    cmbGrado.Text = null;
                    TxtCod_Militar1.Text = null;
                    TxtCod_Militar2.Text = null;
                    cmbDestino.Text = null;
                    TxtSubproducto.Text = null;
                    TxtTasa_E_A.Text = null;
                    TxtTasa_N_M.Text = null;
                    TxtMonto_Aprobado.Text = null;
                    TxtPlazo_Aprobado.Text = null;
                    TxtValor_Cuota.Text = null;
                    TxtTotal_Credito.Text = null;
                    TxtMonto_Letras.Text = null;
                    TxtTotal_Letras.Text = null;
                    TxtCartera1.Text = null;
                    TxtCartera2.Text = null;
                    TxtCartera3.Text = null;
                    TxtCartera4.Text = null;
                    dtpFecha_Envio.Text = null;
                    cmbCorte_Envio.Text = null;
                    dtpHora_Envio.Text = "01/01/2020"; 
                    dtpFecha_Posible_Rta.Text = "01/01/2020";
                    dtpFecha_Restriccion.Text = "01/01/2020";
                    cmbEstado_Operacion.Text = null;
                    cmbTipologia.Text = null;
                    TxtEstado_Correo.Text = null;
                    TtxRespuesta_Correo.Text = null;
                    dtpFecha_Cierre_Etapa.Text = "01/01/2020";
                    TxtComentarios.Text = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {                  
                MessageBox.Show("Caso no existe", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Buscar_matriz( TextBox TxtNombre_Convenio,TextBox TtxRestriccion , TextBox TxtDocumentos_Requeridos, 
                                   TextBox TxtHorarios_Gestion, TextBox TxtCondiciones_Especiales, TextBox TxtPaz_Salvo, 
                                   TextBox TxtContacto_Convenio, TextBox TxtContacto_Gic, TextBox TxtFecha_Actualizacion_Matriz)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Buscar_matriz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Codigo_Convenio", usuario.Codigo_matriz2);
                MySqlDataReader registro;
                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    TxtNombre_Convenio.Text = registro["Nombre_Convenio"].ToString();                    
                    TtxRestriccion.Text = registro["Restriccion"].ToString();
                    TxtDocumentos_Requeridos.Text = registro["Documentacion"].ToString();                   
                    TxtHorarios_Gestion.Text = registro["Horarios_Gestion"].ToString();
                    TxtCondiciones_Especiales.Text = registro["Condiciones_Especiales"].ToString();
                    TxtPaz_Salvo.Text = registro["Paz_Salvo"].ToString();
                    TxtContacto_Convenio.Text = registro["Correo_Convenio"].ToString();
                    TxtContacto_Gic.Text = registro["Correo_GicVb"].ToString();
                    TxtFecha_Actualizacion_Matriz.Text = registro["Fecha_Actualizacion_Matriz"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Consecutivo no existe en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtNombre_Convenio.Text = null;
                    TtxRestriccion.Text = null;
                    TxtDocumentos_Requeridos.Text = null;
                    TxtHorarios_Gestion.Text = null;
                    TxtCondiciones_Especiales.Text = null;
                    TxtPaz_Salvo.Text = null;
                    TxtContacto_Convenio.Text = null;
                    TxtContacto_Gic.Text = null;
                    TxtFecha_Actualizacion_Matriz.Text = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Consecutivo no existe", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Enviar_correos(DateTimePicker dtpfecha, TextBox Txtcod_convenio, DateTimePicker dtpHora_Envio, DataGridView dgvDatos)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("enviar_correo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Fecha_Envio", dtpfecha.Text);
                cmd.Parameters.AddWithValue("@_Cod_Matriz", Txtcod_convenio.Text);
                cmd.Parameters.AddWithValue("@_Hora_Envio", dtpHora_Envio.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                MySqlDataAdapter registro = new MySqlDataAdapter(cmd);
                registro.Fill(dt);
                dgvDatos.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pendiente_correo2(Label lblfecha, Label lbltotal)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("total_pendientes_correo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Fecha_Envio", lblfecha.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                MySqlDataReader registro;
                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    lbltotal.Text = registro[0].ToString();                    
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No hay datos para enviar el dia de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Consecutivo no existe", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Estado_Operaciones(DataGridView dgvDatos, ComboBox cmbEstado_Operacion)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("estado_operaciones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Estado_Operacion", cmbEstado_Operacion.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                MySqlDataAdapter registro = new MySqlDataAdapter(cmd);
                registro.Fill(dt);
                dgvDatos.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pendiente_correo3(Label lblfecha, Label lblanterior)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("total_pendientes_correo1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Fecha_Envio", lblfecha.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                MySqlDataReader registro;
                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    lblanterior.Text = registro[0].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No hay datos para enviar el dia de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Consecutivo no existe", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pendiente_correo4(DataGridView dgvCorreos_Pendientes, Label lblfecha)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("pendiente_correo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Fecha_Envio", lblfecha.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                MySqlDataAdapter registro = new MySqlDataAdapter(cmd);
                registro.Fill(dt);
                dgvCorreos_Pendientes.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pendiente_correo(DataGridView dgvCorreos_Pendientes,DateTimePicker dtpfecha)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("pendiente_correo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Fecha_Envio", dtpfecha.Text);
                cmd.Parameters.AddWithValue("@_Nombre_Funcionario", usuario.Nombre);
                MySqlDataAdapter registro = new MySqlDataAdapter(cmd);
                registro.Fill(dt);
                dgvCorreos_Pendientes.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizaBD_Envio(DataGridView dgvDatos)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("actualizarbd_envio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@_Radicado", Convert.ToString(row.Cells[0].Value));
                    cmd.Parameters.AddWithValue("@_Estado_Correo", "Enviado");
                    cmd.Parameters.AddWithValue("@_Respuesta_Correo", "Pendiente Respuesta");                    
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Información Actualizada con Éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvDatos.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Datos_matriz(TextBox TxtNombre_Conveniomt,TextBox TxtRestriccionmt, TextBox Txt_Horarios_gestionmt, TextBox TxtCod_Matriz)
        {
            MySqlCommand comando = new MySqlCommand("SELECT Nombre_Convenio,Restriccion,Horarios_Gestion FROM matriz_convenios WHERE Codigo_Convenio = @Codigo_Convenio ", con);
            comando.Parameters.AddWithValue("@Codigo_Convenio", TxtCod_Matriz.Text);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombre_Conveniomt.Text = registro["Nombre_Convenio"].ToString();
                TxtRestriccionmt.Text = registro["Restriccion"].ToString();
                Txt_Horarios_gestionmt.Text = registro["Horarios_Gestion"].ToString();
                con.Close();
            }
            else
            {
                con.Close();
                TxtNombre_Conveniomt.Text = null;
                TxtRestriccionmt.Text = null;
                Txt_Horarios_gestionmt.Text = null;
                MessageBox.Show("Consecutivo no se encuentra en la matriz, por favor reportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        
    }
}

