/*
 * ex: set ro:
 * DO NOT EDIT.
 * generated by smc (http://smc.sourceforge.net/)
 * from file : tsip_dialog_subscribe.sm
 */


/*
* Copyright (C) 2009 Mamadou Diop.
*
* Contact: Mamadou Diop <diopmamadou@yahoo.fr>
*	
* This file is part of Open Source Doubango Framework.
*
* DOUBANGO is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*	
* DOUBANGO is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
*	
* You should have received a copy of the GNU General Public License
* along with DOUBANGO.
*
*/

/**@file tsip_dialog_subscribe.sm.
 * @brief SIP dialog SUBSCRIBE (RFC 2543).
 *
 * @author Mamadou Diop <diopmamadou(at)yahoo.fr>
 *
 * @date Created: Sat Nov 8 16:54:58 2009 mdiop
 */



#include <assert.h>
#include "tinysip/dialogs/tsip_dialog_subscribe.h"
#include "tsk_debug.h"
#include "tinySIP/smc/tsip_dialog_subscribe_sm.h"

#define getOwner(fsm) \
    (fsm)->_owner

#define POPULATE_STATE(state) \
    state##_Entry, \
    state##_sm_1xx, \
    state##_sm_2xx, \
    state##_sm_300_to_699, \
    state##_sm_401_407_421_494, \
    state##_sm_423, \
    state##_sm_NOTIFY, \
    state##_sm_cancel, \
    state##_sm_error, \
    state##_sm_hangup, \
    state##_sm_refresh, \
    state##_sm_send, \
    state##_sm_transportError, \
    state##_sm_unsubscribe, \
    state##_Default

#define ENTRY_STATE(state) \
    if ((state)->Entry != NULL) { \
        (state)->Entry(fsm); \
    }

#define EXIT_STATE(state)

static void tsip_dialog_subscribeState_sm_1xx(struct tsip_dialog_subscribeContext *fsm, const tsip_message_t* msg)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_2xx(struct tsip_dialog_subscribeContext *fsm, int unsubscribeing, const tsip_response_t* response)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_300_to_699(struct tsip_dialog_subscribeContext *fsm, const tsip_response_t* response)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_401_407_421_494(struct tsip_dialog_subscribeContext *fsm, const tsip_response_t* response)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_423(struct tsip_dialog_subscribeContext *fsm, const tsip_response_t* response)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_NOTIFY(struct tsip_dialog_subscribeContext *fsm, int sterminated, const tsip_request_t* request)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_cancel(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_error(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_hangup(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_refresh(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_send(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_transportError(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_sm_unsubscribe(struct tsip_dialog_subscribeContext *fsm)
{
    getState(fsm)->Default(fsm);
}

static void tsip_dialog_subscribeState_Default(struct tsip_dialog_subscribeContext *fsm)
{
    State_Default(fsm);
}

#define tsip_dialog_subscribe_Started_sm_1xx tsip_dialog_subscribeState_sm_1xx
#define tsip_dialog_subscribe_Started_sm_2xx tsip_dialog_subscribeState_sm_2xx
#define tsip_dialog_subscribe_Started_sm_300_to_699 tsip_dialog_subscribeState_sm_300_to_699
#define tsip_dialog_subscribe_Started_sm_401_407_421_494 tsip_dialog_subscribeState_sm_401_407_421_494
#define tsip_dialog_subscribe_Started_sm_423 tsip_dialog_subscribeState_sm_423
#define tsip_dialog_subscribe_Started_sm_NOTIFY tsip_dialog_subscribeState_sm_NOTIFY
#define tsip_dialog_subscribe_Started_sm_cancel tsip_dialog_subscribeState_sm_cancel
#define tsip_dialog_subscribe_Started_sm_error tsip_dialog_subscribeState_sm_error
#define tsip_dialog_subscribe_Started_sm_hangup tsip_dialog_subscribeState_sm_hangup
#define tsip_dialog_subscribe_Started_sm_refresh tsip_dialog_subscribeState_sm_refresh
#define tsip_dialog_subscribe_Started_sm_send tsip_dialog_subscribeState_sm_send
#define tsip_dialog_subscribe_Started_sm_transportError tsip_dialog_subscribeState_sm_transportError
#define tsip_dialog_subscribe_Started_sm_unsubscribe tsip_dialog_subscribeState_sm_unsubscribe
#define tsip_dialog_subscribe_Started_Default tsip_dialog_subscribeState_Default
#define tsip_dialog_subscribe_Started_Entry NULL
#define tsip_dialog_subscribe_Started_Exit NULL
#define tsip_dialog_subscribe_Trying_sm_1xx tsip_dialog_subscribeState_sm_1xx
#define tsip_dialog_subscribe_Trying_sm_2xx tsip_dialog_subscribeState_sm_2xx
#define tsip_dialog_subscribe_Trying_sm_300_to_699 tsip_dialog_subscribeState_sm_300_to_699
#define tsip_dialog_subscribe_Trying_sm_401_407_421_494 tsip_dialog_subscribeState_sm_401_407_421_494
#define tsip_dialog_subscribe_Trying_sm_423 tsip_dialog_subscribeState_sm_423
#define tsip_dialog_subscribe_Trying_sm_NOTIFY tsip_dialog_subscribeState_sm_NOTIFY
#define tsip_dialog_subscribe_Trying_sm_cancel tsip_dialog_subscribeState_sm_cancel
#define tsip_dialog_subscribe_Trying_sm_error tsip_dialog_subscribeState_sm_error
#define tsip_dialog_subscribe_Trying_sm_hangup tsip_dialog_subscribeState_sm_hangup
#define tsip_dialog_subscribe_Trying_sm_refresh tsip_dialog_subscribeState_sm_refresh
#define tsip_dialog_subscribe_Trying_sm_send tsip_dialog_subscribeState_sm_send
#define tsip_dialog_subscribe_Trying_sm_transportError tsip_dialog_subscribeState_sm_transportError
#define tsip_dialog_subscribe_Trying_sm_unsubscribe tsip_dialog_subscribeState_sm_unsubscribe
#define tsip_dialog_subscribe_Trying_Default tsip_dialog_subscribeState_Default
#define tsip_dialog_subscribe_Trying_Entry NULL
#define tsip_dialog_subscribe_Trying_Exit NULL
#define tsip_dialog_subscribe_Connected_sm_1xx tsip_dialog_subscribeState_sm_1xx
#define tsip_dialog_subscribe_Connected_sm_2xx tsip_dialog_subscribeState_sm_2xx
#define tsip_dialog_subscribe_Connected_sm_300_to_699 tsip_dialog_subscribeState_sm_300_to_699
#define tsip_dialog_subscribe_Connected_sm_401_407_421_494 tsip_dialog_subscribeState_sm_401_407_421_494
#define tsip_dialog_subscribe_Connected_sm_423 tsip_dialog_subscribeState_sm_423
#define tsip_dialog_subscribe_Connected_sm_NOTIFY tsip_dialog_subscribeState_sm_NOTIFY
#define tsip_dialog_subscribe_Connected_sm_cancel tsip_dialog_subscribeState_sm_cancel
#define tsip_dialog_subscribe_Connected_sm_error tsip_dialog_subscribeState_sm_error
#define tsip_dialog_subscribe_Connected_sm_hangup tsip_dialog_subscribeState_sm_hangup
#define tsip_dialog_subscribe_Connected_sm_refresh tsip_dialog_subscribeState_sm_refresh
#define tsip_dialog_subscribe_Connected_sm_send tsip_dialog_subscribeState_sm_send
#define tsip_dialog_subscribe_Connected_sm_transportError tsip_dialog_subscribeState_sm_transportError
#define tsip_dialog_subscribe_Connected_sm_unsubscribe tsip_dialog_subscribeState_sm_unsubscribe
#define tsip_dialog_subscribe_Connected_Default tsip_dialog_subscribeState_Default
#define tsip_dialog_subscribe_Connected_Entry NULL
#define tsip_dialog_subscribe_Connected_Exit NULL
#define tsip_dialog_subscribe_Terminated_sm_1xx tsip_dialog_subscribeState_sm_1xx
#define tsip_dialog_subscribe_Terminated_sm_2xx tsip_dialog_subscribeState_sm_2xx
#define tsip_dialog_subscribe_Terminated_sm_300_to_699 tsip_dialog_subscribeState_sm_300_to_699
#define tsip_dialog_subscribe_Terminated_sm_401_407_421_494 tsip_dialog_subscribeState_sm_401_407_421_494
#define tsip_dialog_subscribe_Terminated_sm_423 tsip_dialog_subscribeState_sm_423
#define tsip_dialog_subscribe_Terminated_sm_NOTIFY tsip_dialog_subscribeState_sm_NOTIFY
#define tsip_dialog_subscribe_Terminated_sm_cancel tsip_dialog_subscribeState_sm_cancel
#define tsip_dialog_subscribe_Terminated_sm_error tsip_dialog_subscribeState_sm_error
#define tsip_dialog_subscribe_Terminated_sm_hangup tsip_dialog_subscribeState_sm_hangup
#define tsip_dialog_subscribe_Terminated_sm_refresh tsip_dialog_subscribeState_sm_refresh
#define tsip_dialog_subscribe_Terminated_sm_send tsip_dialog_subscribeState_sm_send
#define tsip_dialog_subscribe_Terminated_sm_transportError tsip_dialog_subscribeState_sm_transportError
#define tsip_dialog_subscribe_Terminated_sm_unsubscribe tsip_dialog_subscribeState_sm_unsubscribe
#define tsip_dialog_subscribe_Terminated_Default tsip_dialog_subscribeState_Default
#define tsip_dialog_subscribe_Terminated_Entry NULL
#define tsip_dialog_subscribe_Terminated_Exit NULL
#define tsip_dialog_subscribe_DefaultState_sm_1xx tsip_dialog_subscribeState_sm_1xx
#define tsip_dialog_subscribe_DefaultState_sm_2xx tsip_dialog_subscribeState_sm_2xx
#define tsip_dialog_subscribe_DefaultState_sm_300_to_699 tsip_dialog_subscribeState_sm_300_to_699
#define tsip_dialog_subscribe_DefaultState_sm_401_407_421_494 tsip_dialog_subscribeState_sm_401_407_421_494
#define tsip_dialog_subscribe_DefaultState_sm_423 tsip_dialog_subscribeState_sm_423
#define tsip_dialog_subscribe_DefaultState_sm_NOTIFY tsip_dialog_subscribeState_sm_NOTIFY
#define tsip_dialog_subscribe_DefaultState_sm_cancel tsip_dialog_subscribeState_sm_cancel
#define tsip_dialog_subscribe_DefaultState_sm_error tsip_dialog_subscribeState_sm_error
#define tsip_dialog_subscribe_DefaultState_sm_hangup tsip_dialog_subscribeState_sm_hangup
#define tsip_dialog_subscribe_DefaultState_sm_refresh tsip_dialog_subscribeState_sm_refresh
#define tsip_dialog_subscribe_DefaultState_sm_send tsip_dialog_subscribeState_sm_send
#define tsip_dialog_subscribe_DefaultState_sm_transportError tsip_dialog_subscribeState_sm_transportError
#define tsip_dialog_subscribe_DefaultState_sm_unsubscribe tsip_dialog_subscribeState_sm_unsubscribe

#undef tsip_dialog_subscribe_Started_sm_hangup
#define tsip_dialog_subscribe_Started_sm_hangup tsip_dialog_subscribe_DefaultState_sm_hangup
#undef tsip_dialog_subscribe_Trying_sm_hangup
#define tsip_dialog_subscribe_Trying_sm_hangup tsip_dialog_subscribe_DefaultState_sm_hangup
#undef tsip_dialog_subscribe_Connected_sm_hangup
#define tsip_dialog_subscribe_Connected_sm_hangup tsip_dialog_subscribe_DefaultState_sm_hangup
#undef tsip_dialog_subscribe_Terminated_sm_hangup
#define tsip_dialog_subscribe_Terminated_sm_hangup tsip_dialog_subscribe_DefaultState_sm_hangup
#undef tsip_dialog_subscribe_DefaultState_sm_hangup
static void tsip_dialog_subscribe_DefaultState_sm_hangup(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Any_2_Trying_X_hangup(ctxt);
    setState(fsm, &tsip_dialog_subscribe_Trying);
    ENTRY_STATE(getState(fsm));
}

#undef tsip_dialog_subscribe_Started_sm_transportError
#define tsip_dialog_subscribe_Started_sm_transportError tsip_dialog_subscribe_DefaultState_sm_transportError
#undef tsip_dialog_subscribe_Trying_sm_transportError
#define tsip_dialog_subscribe_Trying_sm_transportError tsip_dialog_subscribe_DefaultState_sm_transportError
#undef tsip_dialog_subscribe_Connected_sm_transportError
#define tsip_dialog_subscribe_Connected_sm_transportError tsip_dialog_subscribe_DefaultState_sm_transportError
#undef tsip_dialog_subscribe_Terminated_sm_transportError
#define tsip_dialog_subscribe_Terminated_sm_transportError tsip_dialog_subscribe_DefaultState_sm_transportError
#undef tsip_dialog_subscribe_DefaultState_sm_transportError
static void tsip_dialog_subscribe_DefaultState_sm_transportError(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Any_2_Terminated_X_transportError(ctxt);
    setState(fsm, &tsip_dialog_subscribe_Terminated);
    ENTRY_STATE(getState(fsm));
}

#undef tsip_dialog_subscribe_Started_sm_error
#define tsip_dialog_subscribe_Started_sm_error tsip_dialog_subscribe_DefaultState_sm_error
#undef tsip_dialog_subscribe_Trying_sm_error
#define tsip_dialog_subscribe_Trying_sm_error tsip_dialog_subscribe_DefaultState_sm_error
#undef tsip_dialog_subscribe_Connected_sm_error
#define tsip_dialog_subscribe_Connected_sm_error tsip_dialog_subscribe_DefaultState_sm_error
#undef tsip_dialog_subscribe_Terminated_sm_error
#define tsip_dialog_subscribe_Terminated_sm_error tsip_dialog_subscribe_DefaultState_sm_error
#undef tsip_dialog_subscribe_DefaultState_sm_error
static void tsip_dialog_subscribe_DefaultState_sm_error(struct tsip_dialog_subscribeContext *fsm)
{

    EXIT_STATE(getState(fsm));
    setState(fsm, &tsip_dialog_subscribe_Terminated);
    ENTRY_STATE(getState(fsm));
}

#undef tsip_dialog_subscribe_Started_Default
#define tsip_dialog_subscribe_Started_Default tsip_dialog_subscribe_DefaultState_Default
#undef tsip_dialog_subscribe_Trying_Default
#define tsip_dialog_subscribe_Trying_Default tsip_dialog_subscribe_DefaultState_Default
#undef tsip_dialog_subscribe_Connected_Default
#define tsip_dialog_subscribe_Connected_Default tsip_dialog_subscribe_DefaultState_Default
#undef tsip_dialog_subscribe_Terminated_Default
#define tsip_dialog_subscribe_Terminated_Default tsip_dialog_subscribe_DefaultState_Default
#undef tsip_dialog_subscribe_DefaultState_Default
static void tsip_dialog_subscribe_DefaultState_Default(struct tsip_dialog_subscribeContext *fsm)
{

}

#undef tsip_dialog_subscribe_Started_Default
static void tsip_dialog_subscribe_Started_Default(struct tsip_dialog_subscribeContext *fsm)
{

}

#undef tsip_dialog_subscribe_Started_sm_send
static void tsip_dialog_subscribe_Started_sm_send(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Started_2_Trying_X_send(ctxt);
    setState(fsm, &tsip_dialog_subscribe_Trying);
    ENTRY_STATE(getState(fsm));
}

const struct tsip_dialog_subscribeState tsip_dialog_subscribe_Started = { POPULATE_STATE(tsip_dialog_subscribe_Started), "tsip_dialog_subscribe_Started", 0 };

#undef tsip_dialog_subscribe_Trying_Default
static void tsip_dialog_subscribe_Trying_Default(struct tsip_dialog_subscribeContext *fsm)
{

}

#undef tsip_dialog_subscribe_Trying_sm_1xx
static void tsip_dialog_subscribe_Trying_sm_1xx(struct tsip_dialog_subscribeContext *fsm, const tsip_message_t* msg)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);
    const struct tsip_dialog_subscribeState* EndStateName = getState(fsm);

    clearState(fsm);
    tsip_dialog_subscribe_Trying_2_Trying_X_1xx(ctxt, msg);
    setState(fsm, EndStateName);
}

#undef tsip_dialog_subscribe_Trying_sm_2xx
static void tsip_dialog_subscribe_Trying_sm_2xx(struct tsip_dialog_subscribeContext *fsm, int unsubscribeing, const tsip_response_t* response)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    if (unsubscribeing) {
        EXIT_STATE(getState(fsm));
        clearState(fsm);
        tsip_dialog_subscribe_Trying_2_Terminated_X_2xx(ctxt, response);
        setState(fsm, &tsip_dialog_subscribe_Terminated);
        ENTRY_STATE(getState(fsm));
    }
    else if (!unsubscribeing) {
        EXIT_STATE(getState(fsm));
        clearState(fsm);
        tsip_dialog_subscribe_Trying_2_Connected_X_2xx(ctxt, response);
        setState(fsm, &tsip_dialog_subscribe_Connected);
        ENTRY_STATE(getState(fsm));
    }    else {
        tsip_dialog_subscribe_DefaultState_sm_2xx(fsm, unsubscribeing, response);
    }
}

#undef tsip_dialog_subscribe_Trying_sm_300_to_699
static void tsip_dialog_subscribe_Trying_sm_300_to_699(struct tsip_dialog_subscribeContext *fsm, const tsip_response_t* response)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Trying_2_Terminated_X_300_to_699(ctxt, response);
    setState(fsm, &tsip_dialog_subscribe_Terminated);
    ENTRY_STATE(getState(fsm));
}

#undef tsip_dialog_subscribe_Trying_sm_401_407_421_494
static void tsip_dialog_subscribe_Trying_sm_401_407_421_494(struct tsip_dialog_subscribeContext *fsm, const tsip_response_t* response)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);
    const struct tsip_dialog_subscribeState* EndStateName = getState(fsm);

    clearState(fsm);
    tsip_dialog_subscribe_Trying_2_Trying_X_401_407_421_494(ctxt, response);
    setState(fsm, EndStateName);
}

#undef tsip_dialog_subscribe_Trying_sm_423
static void tsip_dialog_subscribe_Trying_sm_423(struct tsip_dialog_subscribeContext *fsm, const tsip_response_t* response)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);
    const struct tsip_dialog_subscribeState* EndStateName = getState(fsm);

    clearState(fsm);
    tsip_dialog_subscribe_Trying_2_Trying_X_423(ctxt, response);
    setState(fsm, EndStateName);
}

#undef tsip_dialog_subscribe_Trying_sm_NOTIFY
static void tsip_dialog_subscribe_Trying_sm_NOTIFY(struct tsip_dialog_subscribeContext *fsm, int sterminated, const tsip_request_t* request)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);
    const struct tsip_dialog_subscribeState* EndStateName = getState(fsm);

    clearState(fsm);
    tsip_dialog_subscribe_Trying_2_Trying_X_NOTIFY(ctxt, request);
    setState(fsm, EndStateName);
}

#undef tsip_dialog_subscribe_Trying_sm_cancel
static void tsip_dialog_subscribe_Trying_sm_cancel(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Trying_2_Terminated_X_cancel(ctxt);
    setState(fsm, &tsip_dialog_subscribe_Terminated);
    ENTRY_STATE(getState(fsm));
}

const struct tsip_dialog_subscribeState tsip_dialog_subscribe_Trying = { POPULATE_STATE(tsip_dialog_subscribe_Trying), "tsip_dialog_subscribe_Trying", 1 };

#undef tsip_dialog_subscribe_Connected_Default
static void tsip_dialog_subscribe_Connected_Default(struct tsip_dialog_subscribeContext *fsm)
{

}

#undef tsip_dialog_subscribe_Connected_sm_NOTIFY
static void tsip_dialog_subscribe_Connected_sm_NOTIFY(struct tsip_dialog_subscribeContext *fsm, int sterminated, const tsip_request_t* request)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    if (!sterminated) {
        const struct tsip_dialog_subscribeState* EndStateName = getState(fsm);

        clearState(fsm);
        tsip_dialog_subscribe_Connected_2_Connected_X_NOTIFY(ctxt, request);
        setState(fsm, EndStateName);
    }
    else if (sterminated) {
        EXIT_STATE(getState(fsm));
        clearState(fsm);
        tsip_dialog_subscribe_Connected_2_Terminated_X_NOTIFY(ctxt, request);
        setState(fsm, &tsip_dialog_subscribe_Terminated);
        ENTRY_STATE(getState(fsm));
    }    else {
        tsip_dialog_subscribe_DefaultState_sm_NOTIFY(fsm, sterminated, request);
    }
}

#undef tsip_dialog_subscribe_Connected_sm_refresh
static void tsip_dialog_subscribe_Connected_sm_refresh(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Connected_2_Trying_X_refresh(ctxt);
    setState(fsm, &tsip_dialog_subscribe_Trying);
    ENTRY_STATE(getState(fsm));
}

#undef tsip_dialog_subscribe_Connected_sm_unsubscribe
static void tsip_dialog_subscribe_Connected_sm_unsubscribe(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe* ctxt = getOwner(fsm);

    EXIT_STATE(getState(fsm));
    clearState(fsm);
    tsip_dialog_subscribe_Connected_2_Trying_X_unsubscribe(ctxt);
    setState(fsm, &tsip_dialog_subscribe_Trying);
    ENTRY_STATE(getState(fsm));
}

const struct tsip_dialog_subscribeState tsip_dialog_subscribe_Connected = { POPULATE_STATE(tsip_dialog_subscribe_Connected), "tsip_dialog_subscribe_Connected", 2 };

#undef tsip_dialog_subscribe_Terminated_Entry
void tsip_dialog_subscribe_Terminated_Entry(struct tsip_dialog_subscribeContext *fsm)
{
    struct tsip_dialog_subscribe *ctxt = getOwner(fsm);

    tsip_dialog_subscribe_OnTerminated(ctxt);
}

#undef tsip_dialog_subscribe_Terminated_Default
static void tsip_dialog_subscribe_Terminated_Default(struct tsip_dialog_subscribeContext *fsm)
{

}

const struct tsip_dialog_subscribeState tsip_dialog_subscribe_Terminated = { POPULATE_STATE(tsip_dialog_subscribe_Terminated), "tsip_dialog_subscribe_Terminated", 3 };

void tsip_dialog_subscribeContext_Init(struct tsip_dialog_subscribeContext* fsm, struct tsip_dialog_subscribe* owner)
{
    FSM_INIT(fsm, &tsip_dialog_subscribe_Started);
    fsm->_owner = owner;
}

void tsip_dialog_subscribeContext_EnterStartState(struct tsip_dialog_subscribeContext* fsm)
{
    ENTRY_STATE(getState(fsm));
}

void tsip_dialog_subscribeContext_sm_1xx(struct tsip_dialog_subscribeContext* fsm, const tsip_message_t* msg)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_1xx");
    state->sm_1xx(fsm, msg);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_2xx(struct tsip_dialog_subscribeContext* fsm, int unsubscribeing, const tsip_response_t* response)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_2xx");
    state->sm_2xx(fsm, unsubscribeing, response);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_300_to_699(struct tsip_dialog_subscribeContext* fsm, const tsip_response_t* response)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_300_to_699");
    state->sm_300_to_699(fsm, response);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_401_407_421_494(struct tsip_dialog_subscribeContext* fsm, const tsip_response_t* response)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_401_407_421_494");
    state->sm_401_407_421_494(fsm, response);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_423(struct tsip_dialog_subscribeContext* fsm, const tsip_response_t* response)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_423");
    state->sm_423(fsm, response);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_NOTIFY(struct tsip_dialog_subscribeContext* fsm, int sterminated, const tsip_request_t* request)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_NOTIFY");
    state->sm_NOTIFY(fsm, sterminated, request);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_cancel(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_cancel");
    state->sm_cancel(fsm);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_error(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_error");
    state->sm_error(fsm);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_hangup(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_hangup");
    state->sm_hangup(fsm);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_refresh(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_refresh");
    state->sm_refresh(fsm);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_send(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_send");
    state->sm_send(fsm);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_transportError(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_transportError");
    state->sm_transportError(fsm);
    setTransition(fsm, NULL);
}

void tsip_dialog_subscribeContext_sm_unsubscribe(struct tsip_dialog_subscribeContext* fsm)
{
    const struct tsip_dialog_subscribeState* state = getState(fsm);

    assert(state != NULL);
    setTransition(fsm, "sm_unsubscribe");
    state->sm_unsubscribe(fsm);
    setTransition(fsm, NULL);
}

/*
 * Local variables:
 *  buffer-read-only: t
 * End:
 */
