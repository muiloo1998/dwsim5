//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PhaseEnvelopeData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PhaseEnvelopeData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PhaseEnvelopeData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PhaseEnvelopeData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CoolPropPINVOKE.delete_PhaseEnvelopeData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool TypeI {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_TypeI_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = CoolPropPINVOKE.PhaseEnvelopeData_TypeI_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool built {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_built_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = CoolPropPINVOKE.PhaseEnvelopeData_built_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint iTsat_max {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_iTsat_max_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CoolPropPINVOKE.PhaseEnvelopeData_iTsat_max_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint ipsat_max {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_ipsat_max_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CoolPropPINVOKE.PhaseEnvelopeData_ipsat_max_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint icrit {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_icrit_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CoolPropPINVOKE.PhaseEnvelopeData_icrit_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector T {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_T_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_T_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector p {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_p_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_p_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector lnT {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_lnT_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_lnT_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector lnp {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_lnp_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_lnp_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector rhomolar_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_rhomolar_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_rhomolar_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector rhomolar_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_rhomolar_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_rhomolar_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector lnrhomolar_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_lnrhomolar_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_lnrhomolar_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector lnrhomolar_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_lnrhomolar_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_lnrhomolar_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector hmolar_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_hmolar_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_hmolar_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector hmolar_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_hmolar_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_hmolar_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector smolar_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_smolar_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_smolar_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector smolar_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_smolar_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_smolar_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector Q {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_Q_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_Q_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector cpmolar_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_cpmolar_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_cpmolar_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector cpmolar_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_cpmolar_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_cpmolar_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector cvmolar_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_cvmolar_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_cvmolar_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector cvmolar_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_cvmolar_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_cvmolar_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector viscosity_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_viscosity_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_viscosity_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector viscosity_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_viscosity_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_viscosity_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector conductivity_liq {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_conductivity_liq_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_conductivity_liq_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector conductivity_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_conductivity_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_conductivity_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector speed_sound_vap {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_speed_sound_vap_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_speed_sound_vap_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VectorOfDoubleVector K {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_K_set(swigCPtr, VectorOfDoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_K_get(swigCPtr);
      VectorOfDoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfDoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VectorOfDoubleVector lnK {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_lnK_set(swigCPtr, VectorOfDoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_lnK_get(swigCPtr);
      VectorOfDoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfDoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VectorOfDoubleVector x {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_x_set(swigCPtr, VectorOfDoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_x_get(swigCPtr);
      VectorOfDoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfDoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VectorOfDoubleVector y {
    set {
      CoolPropPINVOKE.PhaseEnvelopeData_y_set(swigCPtr, VectorOfDoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.PhaseEnvelopeData_y_get(swigCPtr);
      VectorOfDoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorOfDoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PhaseEnvelopeData() : this(CoolPropPINVOKE.new_PhaseEnvelopeData(), true) {
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(uint N) {
    CoolPropPINVOKE.PhaseEnvelopeData_resize(swigCPtr, N);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    CoolPropPINVOKE.PhaseEnvelopeData_clear(swigCPtr);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public void insert_variables(double T, double p, double rhomolar_liq, double rhomolar_vap, double hmolar_liq, double hmolar_vap, double smolar_liq, double smolar_vap, SWIGTYPE_p_std__vectorT_CoolPropDbl_t x, SWIGTYPE_p_std__vectorT_CoolPropDbl_t y, uint i) {
    CoolPropPINVOKE.PhaseEnvelopeData_insert_variables(swigCPtr, T, p, rhomolar_liq, rhomolar_vap, hmolar_liq, hmolar_vap, smolar_liq, smolar_vap, SWIGTYPE_p_std__vectorT_CoolPropDbl_t.getCPtr(x), SWIGTYPE_p_std__vectorT_CoolPropDbl_t.getCPtr(y), i);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

  public void store_variables(double T, double p, double rhomolar_liq, double rhomolar_vap, double hmolar_liq, double hmolar_vap, double smolar_liq, double smolar_vap, SWIGTYPE_p_std__vectorT_CoolPropDbl_t x, SWIGTYPE_p_std__vectorT_CoolPropDbl_t y) {
    CoolPropPINVOKE.PhaseEnvelopeData_store_variables(swigCPtr, T, p, rhomolar_liq, rhomolar_vap, hmolar_liq, hmolar_vap, smolar_liq, smolar_vap, SWIGTYPE_p_std__vectorT_CoolPropDbl_t.getCPtr(x), SWIGTYPE_p_std__vectorT_CoolPropDbl_t.getCPtr(y));
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

}