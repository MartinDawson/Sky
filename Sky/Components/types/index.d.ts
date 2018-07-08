import { InjectedFormProps } from 'redux-form';

export interface UrlParameter {
  [key: string]: string | number
}

export interface FormState {
  rewards: InjectedFormProps
}

export interface Route {
  router: {
    push: (pathname: string) => void
  }
  error: {
    code: string
    message: string
  }
  props?: any
}

export interface Match {
  location: {
    query: UrlParameter
  }
}
