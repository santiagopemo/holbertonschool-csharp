using System;

    ///<summary> Base class </summary>
    public abstract class Base
    {
     ///<summary> name property </summary>
    private string name {get; set;}
     ///<summary> String representation of the object </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
    }


     ///<summary> IInteractive </summary>
    public interface IInteractive {
         ///<summary> overrider </summary>
        void Interact();
    }
     ///<summary> overrider </summary>
    public interface IBreakable{
         ///<summary> overrider </summary>
         /// <value>Getter and setter</value>
         int durability {get; set;}
          ///<summary> overrider </summary>
         void Break();
    }
     ///<summary> overrider </summary>
    public interface ICollectable{
         ///<summary> overrider </summary>
         /// <value>Getter and setter</value>
        bool isCollected {get; set;}
         ///<summary> overrider </summary>
        void Collect();
    }
     ///<summary> overrider </summary>
    public class TestObject : Base, IInteractive, IBreakable, ICollectable{
         ///<summary> overrider </summary>
         /// <value>Getter and setter</value>
        public int durability {get; set;}
        ///<summary> overrider </summary>
        /// <value>Getter and setter</value>
        public bool isCollected {get; set;}
        ///<summary>  override </summary>
        public string name {get; set;}
        ///<summary> overrider </summary>
        public void Interact(){
            // Method implementation.
        } 
         ///<summary> overrider </summary>
        public void Break(){
            // Method implementation.
        }   
         ///<summary> overrider </summary>
        public void Collect(){
            // Method implementation.
        }
    }
