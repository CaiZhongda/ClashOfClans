/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class FT_DataBase : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FT_DataBase(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FT_DataBase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FT_DataBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FT_DataBase(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public FT_DataBase() : this(RakNetPINVOKE.new_FT_DataBase(), true) {
  }

  public virtual FT_MessageTypesNode NodeType() {
    FT_MessageTypesNode ret = (FT_MessageTypesNode)RakNetPINVOKE.FT_DataBase_NodeType(swigCPtr);
    return ret;
  }

  public virtual void Serialize(bool writeToBitstream, BitStream bs) {
    RakNetPINVOKE.FT_DataBase_Serialize(swigCPtr, writeToBitstream, BitStream.getCPtr(bs));
  }

  public FT_Session session {
    set {
      RakNetPINVOKE.FT_DataBase_session_set(swigCPtr, FT_Session.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FT_DataBase_session_get(swigCPtr);
      FT_Session ret = (cPtr == IntPtr.Zero) ? null : new FT_Session(cPtr, false);
      return ret;
    } 
  }

}

}
