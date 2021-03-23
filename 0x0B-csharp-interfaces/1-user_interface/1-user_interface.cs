using System;

    ///<summary> Base class </summary>
    public abstract class Base
    {
    
    private string name {get; set;}
    
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
    }


    
    public interface IInteractive {
         
        void Interact();
    }
     
    public interface IBreakable{
        int durability {get; set;}
         void Break();
    }
    public interface ICollectable{
        bool isCollected {get; set;}
        void Collect();
    }
    public class TestObject : Base, IInteractive, IBreakable, ICollectable{
        public int durability {get; set;}
        public bool isCollected {get; set;}
        public string name {get; set;}
        public void Interact(){
        } 
        public void Break(){
        }   
        public void Collect(){
        }
    }
