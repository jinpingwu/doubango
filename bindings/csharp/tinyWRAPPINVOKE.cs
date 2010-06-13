/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

class tinyWRAPPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("tinyWRAP", EntryPoint="SWIGRegisterExceptionCallbacks_tinyWRAP")]
    public static extern void SWIGRegisterExceptionCallbacks_tinyWRAP(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("tinyWRAP", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_tinyWRAP")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_tinyWRAP(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_tinyWRAP(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_tinyWRAP(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(tinyWRAPPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(tinyWRAPPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("tinyWRAP", EntryPoint="SWIGRegisterStringCallback_tinyWRAP")]
    public static extern void SWIGRegisterStringCallback_tinyWRAP(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_tinyWRAP(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  [DllImport("tinyWRAP", EntryPoint="CSharp_new_DDebugCallback")]
  public static extern IntPtr new_DDebugCallback();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_DDebugCallback")]
  public static extern void delete_DDebugCallback(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_DDebugCallback_OnDebugInfo")]
  public static extern int DDebugCallback_OnDebugInfo(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_DDebugCallback_OnDebugWarn")]
  public static extern int DDebugCallback_OnDebugWarn(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_DDebugCallback_OnDebugError")]
  public static extern int DDebugCallback_OnDebugError(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_DDebugCallback_OnDebugFatal")]
  public static extern int DDebugCallback_OnDebugFatal(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipUri")]
  public static extern IntPtr new_SipUri(string jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipUri")]
  public static extern void delete_SipUri(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipUri_isValid__SWIG_0")]
  public static extern bool SipUri_isValid__SWIG_0(string jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipUri_isValid__SWIG_1")]
  public static extern bool SipUri_isValid__SWIG_1(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipMessage")]
  public static extern IntPtr new_SipMessage();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipMessage")]
  public static extern void delete_SipMessage(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipMessage_getSipHeaderValue__SWIG_0")]
  public static extern string SipMessage_getSipHeaderValue__SWIG_0(HandleRef jarg1, string jarg2, uint jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipMessage_getSipHeaderValue__SWIG_1")]
  public static extern string SipMessage_getSipHeaderValue__SWIG_1(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipMessage_getSipHeaderParamValue__SWIG_0")]
  public static extern string SipMessage_getSipHeaderParamValue__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, uint jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipMessage_getSipHeaderParamValue__SWIG_1")]
  public static extern string SipMessage_getSipHeaderParamValue__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipMessage_getSipContentLength")]
  public static extern uint SipMessage_getSipContentLength(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipMessage_getSipContent")]
  public static extern uint SipMessage_getSipContent(HandleRef jarg1, byte[] jarg2, uint jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipEvent")]
  public static extern void delete_SipEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getCode")]
  public static extern short SipEvent_getCode(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getPhrase")]
  public static extern string SipEvent_getPhrase(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getBaseSession")]
  public static extern IntPtr SipEvent_getBaseSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getSipMessage")]
  public static extern IntPtr SipEvent_getSipMessage(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_DialogEvent")]
  public static extern void delete_DialogEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_StackEvent")]
  public static extern void delete_StackEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_MessagingEvent")]
  public static extern void delete_MessagingEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingEvent_getType")]
  public static extern int MessagingEvent_getType(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingEvent_getSession")]
  public static extern IntPtr MessagingEvent_getSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingEvent_takeSessionOwnership")]
  public static extern IntPtr MessagingEvent_takeSessionOwnership(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_OptionsEvent")]
  public static extern void delete_OptionsEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_OptionsEvent_getType")]
  public static extern int OptionsEvent_getType(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_OptionsEvent_getSession")]
  public static extern IntPtr OptionsEvent_getSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_PublicationEvent")]
  public static extern void delete_PublicationEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_PublicationEvent_getType")]
  public static extern int PublicationEvent_getType(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_PublicationEvent_getSession")]
  public static extern IntPtr PublicationEvent_getSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_RegistrationEvent")]
  public static extern void delete_RegistrationEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationEvent_getType")]
  public static extern int RegistrationEvent_getType(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationEvent_getSession")]
  public static extern IntPtr RegistrationEvent_getSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SubscriptionEvent")]
  public static extern void delete_SubscriptionEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SubscriptionEvent_getType")]
  public static extern int SubscriptionEvent_getType(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SubscriptionEvent_getSession")]
  public static extern IntPtr SubscriptionEvent_getSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipSession")]
  public static extern IntPtr new_SipSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipSession")]
  public static extern void delete_SipSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_haveOwnership")]
  public static extern bool SipSession_haveOwnership(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_addHeader")]
  public static extern bool SipSession_addHeader(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_removeHeader")]
  public static extern bool SipSession_removeHeader(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_addCaps__SWIG_0")]
  public static extern bool SipSession_addCaps__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_addCaps__SWIG_1")]
  public static extern bool SipSession_addCaps__SWIG_1(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_removeCaps")]
  public static extern bool SipSession_removeCaps(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setExpires")]
  public static extern bool SipSession_setExpires(HandleRef jarg1, uint jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setFromUri")]
  public static extern bool SipSession_setFromUri(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setToUri")]
  public static extern bool SipSession_setToUri(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setSilentHangup")]
  public static extern bool SipSession_setSilentHangup(HandleRef jarg1, bool jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_getId")]
  public static extern uint SipSession_getId(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_CallSession")]
  public static extern IntPtr new_CallSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_CallSession")]
  public static extern void delete_CallSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_CallSession_Call")]
  public static extern bool CallSession_Call(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_CallSession_Hangup")]
  public static extern bool CallSession_Hangup(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_MessagingSession")]
  public static extern IntPtr new_MessagingSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_MessagingSession")]
  public static extern void delete_MessagingSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingSession_Send")]
  public static extern bool MessagingSession_Send(HandleRef jarg1, byte[] jarg2, uint jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingSession_Accept")]
  public static extern bool MessagingSession_Accept(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingSession_Reject")]
  public static extern bool MessagingSession_Reject(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_OptionsSession")]
  public static extern IntPtr new_OptionsSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_OptionsSession")]
  public static extern void delete_OptionsSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_OptionsSession_Send")]
  public static extern bool OptionsSession_Send(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_PublicationSession")]
  public static extern IntPtr new_PublicationSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_PublicationSession")]
  public static extern void delete_PublicationSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_PublicationSession_Publish")]
  public static extern bool PublicationSession_Publish(HandleRef jarg1, byte[] jarg2, uint jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_PublicationSession_UnPublish")]
  public static extern bool PublicationSession_UnPublish(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_RegistrationSession")]
  public static extern IntPtr new_RegistrationSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_RegistrationSession")]
  public static extern void delete_RegistrationSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationSession_Register")]
  public static extern bool RegistrationSession_Register(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationSession_UnRegister")]
  public static extern bool RegistrationSession_UnRegister(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SubscriptionSession")]
  public static extern IntPtr new_SubscriptionSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SubscriptionSession")]
  public static extern void delete_SubscriptionSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SubscriptionSession_Subscribe")]
  public static extern bool SubscriptionSession_Subscribe(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SubscriptionSession_UnSubscribe")]
  public static extern bool SubscriptionSession_UnSubscribe(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_ProxyAudioConsumer")]
  public static extern IntPtr new_ProxyAudioConsumer();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_ProxyAudioConsumer")]
  public static extern void delete_ProxyAudioConsumer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_prepare")]
  public static extern int ProxyAudioConsumer_prepare(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_prepareSwigExplicitProxyAudioConsumer")]
  public static extern int ProxyAudioConsumer_prepareSwigExplicitProxyAudioConsumer(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_start")]
  public static extern int ProxyAudioConsumer_start(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_startSwigExplicitProxyAudioConsumer")]
  public static extern int ProxyAudioConsumer_startSwigExplicitProxyAudioConsumer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_pause")]
  public static extern int ProxyAudioConsumer_pause(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_pauseSwigExplicitProxyAudioConsumer")]
  public static extern int ProxyAudioConsumer_pauseSwigExplicitProxyAudioConsumer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_stop")]
  public static extern int ProxyAudioConsumer_stop(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_stopSwigExplicitProxyAudioConsumer")]
  public static extern int ProxyAudioConsumer_stopSwigExplicitProxyAudioConsumer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_setActivate")]
  public static extern void ProxyAudioConsumer_setActivate(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_pull")]
  public static extern uint ProxyAudioConsumer_pull(HandleRef jarg1, byte[] jarg2, uint jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_registerPlugin")]
  public static extern bool ProxyAudioConsumer_registerPlugin();

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioConsumer_director_connect")]
  public static extern void ProxyAudioConsumer_director_connect(HandleRef jarg1, ProxyAudioConsumer.SwigDelegateProxyAudioConsumer_0 delegate0, ProxyAudioConsumer.SwigDelegateProxyAudioConsumer_1 delegate1, ProxyAudioConsumer.SwigDelegateProxyAudioConsumer_2 delegate2, ProxyAudioConsumer.SwigDelegateProxyAudioConsumer_3 delegate3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_ProxyAudioProducer")]
  public static extern IntPtr new_ProxyAudioProducer();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_ProxyAudioProducer")]
  public static extern void delete_ProxyAudioProducer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_prepare")]
  public static extern int ProxyAudioProducer_prepare(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_prepareSwigExplicitProxyAudioProducer")]
  public static extern int ProxyAudioProducer_prepareSwigExplicitProxyAudioProducer(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_start")]
  public static extern int ProxyAudioProducer_start(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_startSwigExplicitProxyAudioProducer")]
  public static extern int ProxyAudioProducer_startSwigExplicitProxyAudioProducer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_pause")]
  public static extern int ProxyAudioProducer_pause(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_pauseSwigExplicitProxyAudioProducer")]
  public static extern int ProxyAudioProducer_pauseSwigExplicitProxyAudioProducer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_stop")]
  public static extern int ProxyAudioProducer_stop(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_stopSwigExplicitProxyAudioProducer")]
  public static extern int ProxyAudioProducer_stopSwigExplicitProxyAudioProducer(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_setActivate")]
  public static extern void ProxyAudioProducer_setActivate(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_push")]
  public static extern int ProxyAudioProducer_push(HandleRef jarg1, byte[] jarg2, uint jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_registerPlugin")]
  public static extern bool ProxyAudioProducer_registerPlugin();

  [DllImport("tinyWRAP", EntryPoint="CSharp_ProxyAudioProducer_director_connect")]
  public static extern void ProxyAudioProducer_director_connect(HandleRef jarg1, ProxyAudioProducer.SwigDelegateProxyAudioProducer_0 delegate0, ProxyAudioProducer.SwigDelegateProxyAudioProducer_1 delegate1, ProxyAudioProducer.SwigDelegateProxyAudioProducer_2 delegate2, ProxyAudioProducer.SwigDelegateProxyAudioProducer_3 delegate3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipCallback")]
  public static extern IntPtr new_SipCallback();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipCallback")]
  public static extern void delete_SipCallback(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnDialogEvent")]
  public static extern int SipCallback_OnDialogEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnDialogEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnDialogEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnStackEvent")]
  public static extern int SipCallback_OnStackEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnStackEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnStackEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnMessagingEvent")]
  public static extern int SipCallback_OnMessagingEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnMessagingEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnMessagingEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnOptionsEvent")]
  public static extern int SipCallback_OnOptionsEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnOptionsEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnOptionsEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnPublicationEvent")]
  public static extern int SipCallback_OnPublicationEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnPublicationEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnPublicationEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnRegistrationEvent")]
  public static extern int SipCallback_OnRegistrationEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnRegistrationEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnRegistrationEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnSubscriptionEvent")]
  public static extern int SipCallback_OnSubscriptionEvent(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnSubscriptionEventSwigExplicitSipCallback")]
  public static extern int SipCallback_OnSubscriptionEventSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_director_connect")]
  public static extern void SipCallback_director_connect(HandleRef jarg1, SipCallback.SwigDelegateSipCallback_0 delegate0, SipCallback.SwigDelegateSipCallback_1 delegate1, SipCallback.SwigDelegateSipCallback_2 delegate2, SipCallback.SwigDelegateSipCallback_3 delegate3, SipCallback.SwigDelegateSipCallback_4 delegate4, SipCallback.SwigDelegateSipCallback_5 delegate5, SipCallback.SwigDelegateSipCallback_6 delegate6);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SafeObject")]
  public static extern IntPtr new_SafeObject();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SafeObject")]
  public static extern void delete_SafeObject(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SafeObject_Lock")]
  public static extern int SafeObject_Lock(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SafeObject_UnLock")]
  public static extern int SafeObject_UnLock(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipStack")]
  public static extern IntPtr new_SipStack(HandleRef jarg1, string jarg2, string jarg3, string jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipStack")]
  public static extern void delete_SipStack(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_start")]
  public static extern bool SipStack_start(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setDebugCallback")]
  public static extern bool SipStack_setDebugCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setRealm")]
  public static extern bool SipStack_setRealm(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setIMPI")]
  public static extern bool SipStack_setIMPI(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setIMPU")]
  public static extern bool SipStack_setIMPU(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setPassword")]
  public static extern bool SipStack_setPassword(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setProxyCSCF")]
  public static extern bool SipStack_setProxyCSCF(HandleRef jarg1, string jarg2, uint jarg3, string jarg4, string jarg5);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setLocalIP")]
  public static extern bool SipStack_setLocalIP(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setLocalPort")]
  public static extern bool SipStack_setLocalPort(HandleRef jarg1, uint jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setEarlyIMS")]
  public static extern bool SipStack_setEarlyIMS(HandleRef jarg1, bool jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_addHeader")]
  public static extern bool SipStack_addHeader(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_removeHeader")]
  public static extern bool SipStack_removeHeader(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_addDnsServer")]
  public static extern bool SipStack_addDnsServer(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setAoR")]
  public static extern bool SipStack_setAoR(HandleRef jarg1, string jarg2, int jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_isValid")]
  public static extern bool SipStack_isValid(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_stop")]
  public static extern bool SipStack_stop(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_transport_error_get")]
  public static extern int tsip_event_code_dialog_transport_error_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_global_error_get")]
  public static extern int tsip_event_code_dialog_global_error_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_message_error_get")]
  public static extern int tsip_event_code_dialog_message_error_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_request_incoming_get")]
  public static extern int tsip_event_code_dialog_request_incoming_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_request_cancelled_get")]
  public static extern int tsip_event_code_dialog_request_cancelled_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_request_sent_get")]
  public static extern int tsip_event_code_dialog_request_sent_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_connecting_get")]
  public static extern int tsip_event_code_dialog_connecting_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_connected_get")]
  public static extern int tsip_event_code_dialog_connected_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_terminating_get")]
  public static extern int tsip_event_code_dialog_terminating_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_dialog_terminated_get")]
  public static extern int tsip_event_code_dialog_terminated_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_stack_started_get")]
  public static extern int tsip_event_code_stack_started_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_stack_stopped_get")]
  public static extern int tsip_event_code_stack_stopped_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_stack_failed_to_start_get")]
  public static extern int tsip_event_code_stack_failed_to_start_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_tsip_event_code_stack_failed_to_stop_get")]
  public static extern int tsip_event_code_stack_failed_to_stop_get();

  [DllImport("tinyWRAP", EntryPoint="CSharp_DialogEventUpcast")]
  public static extern IntPtr DialogEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_StackEventUpcast")]
  public static extern IntPtr StackEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingEventUpcast")]
  public static extern IntPtr MessagingEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_OptionsEventUpcast")]
  public static extern IntPtr OptionsEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_PublicationEventUpcast")]
  public static extern IntPtr PublicationEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationEventUpcast")]
  public static extern IntPtr RegistrationEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SubscriptionEventUpcast")]
  public static extern IntPtr SubscriptionEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_CallSessionUpcast")]
  public static extern IntPtr CallSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_MessagingSessionUpcast")]
  public static extern IntPtr MessagingSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_OptionsSessionUpcast")]
  public static extern IntPtr OptionsSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_PublicationSessionUpcast")]
  public static extern IntPtr PublicationSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationSessionUpcast")]
  public static extern IntPtr RegistrationSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SubscriptionSessionUpcast")]
  public static extern IntPtr SubscriptionSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStackUpcast")]
  public static extern IntPtr SipStackUpcast(IntPtr objectRef);
}
