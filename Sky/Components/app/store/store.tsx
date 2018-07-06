import { Actions as FarceActions, BrowserProtocol, createHistoryEnhancer,
  queryMiddleware } from "farce";
import { createMatchEnhancer, foundReducer as found, Matcher } from "found";
import { applyMiddleware, combineReducers, compose, createStore } from "redux";

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
  found,
});

const store = createStore(reducers, {}, middleWare);

store.dispatch(FarceActions.init());

export default store;
