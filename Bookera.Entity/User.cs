//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookera.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
    	public User()
    	{
    		this.Member = new HashSet<Member>();
    	}
    
    	public int UserId { get; set; }
    	public string Username { get; set; }
    	public string Hash { get; set; }
    	public string Sault { get; set; }
    
    	public virtual ICollection<Member> Member { get; set; }
    }
}
