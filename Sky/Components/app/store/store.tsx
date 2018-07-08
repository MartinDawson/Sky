import { Actions as FarceActions, BrowserProtocol, createHistoryEnhancer,
  queryMiddleware } from "farce";
import { createMatchEnhancer, foundReducer as found, Matcher } from "found";
import { combineReducers, compose, createStore } from "redux";
import { reducer as form } from "redux-form";

import routeConfig from "../routing/routeConfig";

const historyEnhancer = createHistoryEnhancer({
  middlewares: [queryMiddleware],
  protocol: new BrowserProtocol(),
});

const matcherEnhancer = createMatchEnhancer(
  new Matcher(routeConfig),
);

const composeEnhancers = (window as any).window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

const middleWare = composeEnhancers(
  historyEnhancer,
  matcherEnhancer,
);

const reducers = combineReducers({
  form,
  found,
});

const store = createStore(reducers, {}, middleWare);

store.dispatch(FarceActions.init());

export default store;
