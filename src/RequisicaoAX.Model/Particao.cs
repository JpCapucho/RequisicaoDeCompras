/*
 * Created by SharpDevelop.
 * User: Gamer01
 * Date: 09/12/2017
 * Time: 01:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RequisicaoAX.Model
{
	/// <summary>
	/// Partição do sistema
	/// </summary>
	public class Particao
	{
		public virtual string Id { get; set; }
		
		public virtual string Nome { get; set; }
		
		public Particao() {}
			
	}
}
