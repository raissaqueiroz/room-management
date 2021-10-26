using System;
using System.Collections.Generic;
using RoomManagement.Domain.Validators;

namespace RoomManagement.Domain.Entities 
{
    public class Room : Base
    {

        public Room(string name, string description){
            Name = name;
            Description = Description;
            _errors = new List<string>();
        }

        protected Room(){}
        public string Name { get; private set; }
        public string Description { get; private set; }

        public void ChangeName(string name){
            Name = Name;

            Validate();
        }
        public void ChangeDescription(string description){
            Description = Description;

            Validate();
        }

        public override bool Validate(){
            var validator = new RoomValidator();
            var validation = validator.Validate(this);

            if(!validation.IsValid){
                foreach(var error in validation.Errors){
                    _errors.Add(error.ErrorMessage);
                }

                throw new Exception("Alguns campos estão inválidos. " + _errors);
            }

            return true;
        }
    }
}