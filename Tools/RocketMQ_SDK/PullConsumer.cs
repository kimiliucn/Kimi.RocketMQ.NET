//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace ons {

public class PullConsumer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PullConsumer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PullConsumer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PullConsumer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ONSClient4CPPPINVOKE.delete_PullConsumer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PullConsumer() : this(ONSClient4CPPPINVOKE.new_PullConsumer(), true) {
    SwigDirectorConnect();
  }

  public virtual void start() {
    ONSClient4CPPPINVOKE.PullConsumer_start(swigCPtr);
  }

  public virtual void shutdown() {
    ONSClient4CPPPINVOKE.PullConsumer_shutdown(swigCPtr);
  }

  public virtual void fetchSubscribeMessageQueues(string topic, SWIGTYPE_p_std__vectorT_ons__MessageQueueONS_t mqs) {
    ONSClient4CPPPINVOKE.PullConsumer_fetchSubscribeMessageQueues(swigCPtr, topic, SWIGTYPE_p_std__vectorT_ons__MessageQueueONS_t.getCPtr(mqs));
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual PullResultONS pull(MessageQueueONS mq, string subExpression, long offset, int maxNums) {
    PullResultONS ret = new PullResultONS(ONSClient4CPPPINVOKE.PullConsumer_pull(swigCPtr, MessageQueueONS.getCPtr(mq), subExpression, offset, maxNums), true);
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual long searchOffset(MessageQueueONS mq, long timestamp) {
    long ret = ONSClient4CPPPINVOKE.PullConsumer_searchOffset(swigCPtr, MessageQueueONS.getCPtr(mq), timestamp);
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual long maxOffset(MessageQueueONS mq) {
    long ret = ONSClient4CPPPINVOKE.PullConsumer_maxOffset(swigCPtr, MessageQueueONS.getCPtr(mq));
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual long minOffset(MessageQueueONS mq) {
    long ret = ONSClient4CPPPINVOKE.PullConsumer_minOffset(swigCPtr, MessageQueueONS.getCPtr(mq));
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void updateConsumeOffset(MessageQueueONS mq, long offset) {
    ONSClient4CPPPINVOKE.PullConsumer_updateConsumeOffset(swigCPtr, MessageQueueONS.getCPtr(mq), offset);
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeConsumeOffset(MessageQueueONS mq) {
    ONSClient4CPPPINVOKE.PullConsumer_removeConsumeOffset(swigCPtr, MessageQueueONS.getCPtr(mq));
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual long fetchConsumeOffset(MessageQueueONS mq, bool fromStore) {
    long ret = ONSClient4CPPPINVOKE.PullConsumer_fetchConsumeOffset(swigCPtr, MessageQueueONS.getCPtr(mq), fromStore);
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void persistConsumerOffset4PullConsumer(MessageQueueONS mq) {
    ONSClient4CPPPINVOKE.PullConsumer_persistConsumerOffset4PullConsumer(swigCPtr, MessageQueueONS.getCPtr(mq));
    if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("start", swigMethodTypes0))
      swigDelegate0 = new SwigDelegatePullConsumer_0(SwigDirectorstart);
    if (SwigDerivedClassHasMethod("shutdown", swigMethodTypes1))
      swigDelegate1 = new SwigDelegatePullConsumer_1(SwigDirectorshutdown);
    if (SwigDerivedClassHasMethod("fetchSubscribeMessageQueues", swigMethodTypes2))
      swigDelegate2 = new SwigDelegatePullConsumer_2(SwigDirectorfetchSubscribeMessageQueues);
    if (SwigDerivedClassHasMethod("pull", swigMethodTypes3))
      swigDelegate3 = new SwigDelegatePullConsumer_3(SwigDirectorpull);
    if (SwigDerivedClassHasMethod("searchOffset", swigMethodTypes4))
      swigDelegate4 = new SwigDelegatePullConsumer_4(SwigDirectorsearchOffset);
    if (SwigDerivedClassHasMethod("maxOffset", swigMethodTypes5))
      swigDelegate5 = new SwigDelegatePullConsumer_5(SwigDirectormaxOffset);
    if (SwigDerivedClassHasMethod("minOffset", swigMethodTypes6))
      swigDelegate6 = new SwigDelegatePullConsumer_6(SwigDirectorminOffset);
    if (SwigDerivedClassHasMethod("updateConsumeOffset", swigMethodTypes7))
      swigDelegate7 = new SwigDelegatePullConsumer_7(SwigDirectorupdateConsumeOffset);
    if (SwigDerivedClassHasMethod("removeConsumeOffset", swigMethodTypes8))
      swigDelegate8 = new SwigDelegatePullConsumer_8(SwigDirectorremoveConsumeOffset);
    if (SwigDerivedClassHasMethod("fetchConsumeOffset", swigMethodTypes9))
      swigDelegate9 = new SwigDelegatePullConsumer_9(SwigDirectorfetchConsumeOffset);
    if (SwigDerivedClassHasMethod("persistConsumerOffset4PullConsumer", swigMethodTypes10))
      swigDelegate10 = new SwigDelegatePullConsumer_10(SwigDirectorpersistConsumerOffset4PullConsumer);
    ONSClient4CPPPINVOKE.PullConsumer_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(PullConsumer));
    return hasDerivedMethod;
  }

  private void SwigDirectorstart() {
    start();
  }

  private void SwigDirectorshutdown() {
    shutdown();
  }

  private void SwigDirectorfetchSubscribeMessageQueues(string topic, global::System.IntPtr mqs) {
    fetchSubscribeMessageQueues(topic, new SWIGTYPE_p_std__vectorT_ons__MessageQueueONS_t(mqs, false));
  }

  private global::System.IntPtr SwigDirectorpull(global::System.IntPtr mq, string subExpression, long offset, int maxNums) {
    return PullResultONS.getCPtr(pull(new MessageQueueONS(mq, false), subExpression, offset, maxNums)).Handle;
  }

  private long SwigDirectorsearchOffset(global::System.IntPtr mq, long timestamp) {
    return searchOffset(new MessageQueueONS(mq, false), timestamp);
  }

  private long SwigDirectormaxOffset(global::System.IntPtr mq) {
    return maxOffset(new MessageQueueONS(mq, false));
  }

  private long SwigDirectorminOffset(global::System.IntPtr mq) {
    return minOffset(new MessageQueueONS(mq, false));
  }

  private void SwigDirectorupdateConsumeOffset(global::System.IntPtr mq, long offset) {
    updateConsumeOffset(new MessageQueueONS(mq, false), offset);
  }

  private void SwigDirectorremoveConsumeOffset(global::System.IntPtr mq) {
    removeConsumeOffset(new MessageQueueONS(mq, false));
  }

  private long SwigDirectorfetchConsumeOffset(global::System.IntPtr mq, bool fromStore) {
    return fetchConsumeOffset(new MessageQueueONS(mq, false), fromStore);
  }

  private void SwigDirectorpersistConsumerOffset4PullConsumer(global::System.IntPtr mq) {
    persistConsumerOffset4PullConsumer(new MessageQueueONS(mq, false));
  }

  public delegate void SwigDelegatePullConsumer_0();
  public delegate void SwigDelegatePullConsumer_1();
  public delegate void SwigDelegatePullConsumer_2(string topic, global::System.IntPtr mqs);
  public delegate global::System.IntPtr SwigDelegatePullConsumer_3(global::System.IntPtr mq, string subExpression, long offset, int maxNums);
  public delegate long SwigDelegatePullConsumer_4(global::System.IntPtr mq, long timestamp);
  public delegate long SwigDelegatePullConsumer_5(global::System.IntPtr mq);
  public delegate long SwigDelegatePullConsumer_6(global::System.IntPtr mq);
  public delegate void SwigDelegatePullConsumer_7(global::System.IntPtr mq, long offset);
  public delegate void SwigDelegatePullConsumer_8(global::System.IntPtr mq);
  public delegate long SwigDelegatePullConsumer_9(global::System.IntPtr mq, bool fromStore);
  public delegate void SwigDelegatePullConsumer_10(global::System.IntPtr mq);

  private SwigDelegatePullConsumer_0 swigDelegate0;
  private SwigDelegatePullConsumer_1 swigDelegate1;
  private SwigDelegatePullConsumer_2 swigDelegate2;
  private SwigDelegatePullConsumer_3 swigDelegate3;
  private SwigDelegatePullConsumer_4 swigDelegate4;
  private SwigDelegatePullConsumer_5 swigDelegate5;
  private SwigDelegatePullConsumer_6 swigDelegate6;
  private SwigDelegatePullConsumer_7 swigDelegate7;
  private SwigDelegatePullConsumer_8 swigDelegate8;
  private SwigDelegatePullConsumer_9 swigDelegate9;
  private SwigDelegatePullConsumer_10 swigDelegate10;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(string), typeof(SWIGTYPE_p_std__vectorT_ons__MessageQueueONS_t) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(MessageQueueONS), typeof(string), typeof(long), typeof(int) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(MessageQueueONS), typeof(long) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(MessageQueueONS) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(MessageQueueONS) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(MessageQueueONS), typeof(long) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(MessageQueueONS) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(MessageQueueONS), typeof(bool) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(MessageQueueONS) };
}

}
